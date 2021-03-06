// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMaterial")]
    public unsafe partial struct Material
    {
        public Material
        (
            MaterialProperty** mProperties = null,
            uint? mNumProperties = null,
            uint? mNumAllocated = null
        ) : this()
        {
            if (mProperties is not null)
            {
                MProperties = mProperties;
            }

            if (mNumProperties is not null)
            {
                MNumProperties = mNumProperties.Value;
            }

            if (mNumAllocated is not null)
            {
                MNumAllocated = mNumAllocated.Value;
            }
        }


        [NativeName("Type", "aiMaterialProperty **")]
        [NativeName("Type.Name", "aiMaterialProperty **")]
        [NativeName("Name", "mProperties")]
        public MaterialProperty** MProperties;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumProperties")]
        public uint MNumProperties;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumAllocated")]
        public uint MNumAllocated;
    }
}
