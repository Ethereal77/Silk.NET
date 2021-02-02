// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Represents a platform name container.
    /// </summary>
    public class NameContainer
    {
        /// <summary>
        /// Gets or sets the Windows x64 library name.
        /// </summary>
        [JsonProperty("win-x64")]
        public string Windows64 { get; set; }

        /// <summary>
        /// Gets or sets the Windows x64 library name.
        /// </summary>
        [JsonProperty("win-x86")]
        public string Windows86 { get; set; }

        /// <summary>
        /// Gets or sets the class name of the output name container.
        /// </summary>
        [JsonProperty("className")]
        public string ClassName { get; set; }
    }
}
