// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Constructors
{
    /// <summary>
    /// An API constructor for Vulkan.
    /// </summary>
    public class VulkanConstructor : IConstructor
    {
        /// <inheritdoc />
        public void WriteFunctions(Profile profile, IEnumerable<Function> functions, BindTask task)
        {
            foreach (var function in functions)
            {
                if (function.ProfileName != profile.Name || function.ProfileVersion?.ToString(2) != profile.Version)
                {
                    continue;
                }

                foreach (var rawCategory in function.Categories)
                {
                    var category = FormatCategory(rawCategory);
                    var preCategory = $"{task.FunctionPrefixes[0]}_{rawCategory}";
                    // check that the root project exists
                    if (!profile.Projects.ContainsKey("Core"))
                    {
                        profile.Projects.Add
                        (
                            "Core",
                            new Project
                            {
                                IsRoot = true,
                                Namespace = string.Empty,
                                Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                            }
                        );
                    }

                    // check that the extension project exists, if applicable
                    if (function.ExtensionName != "Core" && !profile.Projects.ContainsKey(category))
                    {
                        profile.Projects.Add
                        (
                            category,
                            new Project
                            {
                                IsRoot = false,
                                Namespace = $".{category.CheckMemberName(task.FunctionPrefixes)}",
                                Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                            }
                        );
                    }

                    // check that the interface exists
                    if
                    (
                        !profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Classes[0].NativeApis.ContainsKey(preCategory)
                    )
                    {
                        profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Classes[0].NativeApis.Add
                            (
                                preCategory,
                                new NativeApiSet
                                {
                                    Name =
                                        $"I{Naming.Translate(TrimName(rawCategory, task), task.FunctionPrefixes).CheckMemberName(task.FunctionPrefixes)}"
                                }
                            );
                    }

                    // add the function to the interface
                    profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                        .Classes[0].NativeApis[preCategory]
                        .Functions.Add(function);
                }
            }
        }
        
        /// <inheritdoc />
        public void WriteEnums(Profile profile, IEnumerable<Enum> enums, BindTask task)
        {
            if (!profile.Projects.ContainsKey("Core"))
            {
                profile.Projects.Add
                (
                    "Core",
                    new Project
                    {
                        IsRoot = false,
                        Namespace = string.Empty,
                        Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                    }
                );
            }

            profile.Projects["Core"].Enums.AddRange(enums);
            task.TypeMaps.Add(enums.RemoveDuplicates((x, y) => x.NativeName == y.NativeName).ToDictionary(x => x.NativeName, x => x.Name));
        }
        
        /// <inheritdoc />
        public void WriteStructs(Profile profile, IEnumerable<Struct> structs, BindTask task)
        {
            var map = new Dictionary<string, string>();
            foreach (var @struct in structs)
            {
                if (@struct.ProfileName != profile.Name || @struct.ProfileVersion?.ToString(2) != profile.Version)
                {
                    continue;
                }

                var category = FormatCategory(@struct.ExtensionName);
                
                // check that the root project exists
                if (!profile.Projects.ContainsKey("Core"))
                {
                    profile.Projects.Add
                    (
                        "Core",
                        new Project
                        {IsRoot = true,
                            Namespace = string.Empty,
                            Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                        }
                    );
                }

                // check that the extension project exists, if applicable
                if (@struct.ExtensionName != "Core" && !profile.Projects.ContainsKey(category))
                {
                    profile.Projects.Add
                    (
                        category,
                        new Project
                        {
                            IsRoot = false,
                            Namespace = $".{category.CheckMemberName(task.FunctionPrefixes)}",
                            Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                        }
                    );
                }

                // add the struct
                profile.Projects[@struct.ExtensionName == "Core" ? "Core" : category].Structs.Add(@struct);
                
                // add the struct to the type map
                map[@struct.NativeName] = @struct.Name;
            }
            
            // register the type map
            task.TypeMaps.Add(map);
        }

        /// <inheritdoc />
        public void WriteConstants(Profile profile, IEnumerable<Constant> constants, BindTask task)
        {
            foreach (var constant in constants)
            {
                var category = constant.ExtensionName == "Core" ? "Core" : FormatCategory(constant.ExtensionName);
                
                // check that the root project exists
                if (!profile.Projects.ContainsKey("Core"))
                {
                    profile.Projects.Add
                    (
                        "Core",
                        new Project
                        {IsRoot = true,
                            Namespace = string.Empty,
                            Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                        }
                    );
                }

                // check that the extension project exists, if applicable
                if (constant.ExtensionName != "Core" && !profile.Projects.ContainsKey(category))
                {
                    profile.Projects.Add
                    (
                        category,
                        new Project
                        {
                            IsRoot = false,
                            Namespace = $".{category.CheckMemberName(task.FunctionPrefixes)}",
                            Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                        }
                    );
                }
                
                var constantCollection = profile.Projects[category].Classes[0].Constants;
                if (constantCollection.All(x => x.Name != constant.Name))
                {
                    constantCollection.Add(constant);
                }
            }
        }

        /// <summary>
        /// Trims the API prefix from the function names.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <param name="opts">The converter options.</param>
        /// <returns>The trimmed name.</returns>
        public string TrimName(string name, BindTask task)
        {
            foreach (var prefix in task.FunctionPrefixes)
            {
                if (name.StartsWith($"{prefix.ToUpper()}_"))
                {
                    name = name.Remove(0, prefix.Length + 1);
                }
                else
                {
                    name = name.StartsWith(prefix) ? name.Remove(0, prefix.Length) : name;
                }
            }

            return name;
        }

        private static string FormatCategory(string rawCategory)
        {
            return rawCategory.Split('_').FirstOrDefault();
        }
    }
}
