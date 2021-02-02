// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Contexts
{
    [Flags]
    public enum NativeWindowFlags : ulong
    {
        // 1 << 2 through 1 << 8 have been reserved for future windowing platforms
        Win32 = 1 << 9,
        DirectFB = 1 << 11,
        WinRT = 1 << 15,
        Vivante = 1 << 17,
        OS2 = 1 << 18,
        Haiku = 1 << 19
    }
}
