// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TexBumpParameterATI")]
    public enum TexBumpParameterATI : int
    {
        [NativeName("Name", "GL_BUMP_ROT_MATRIX_ATI")]
        BumpRotMatrixAti = 0x8775,
    }
}
