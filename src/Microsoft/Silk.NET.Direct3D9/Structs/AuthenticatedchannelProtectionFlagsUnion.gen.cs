// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D9
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d9types_L2100_C5")]
    public unsafe partial struct AuthenticatedchannelProtectionFlagsUnion
    {
        public AuthenticatedchannelProtectionFlagsUnion
        (
            AuthenticatedchannelProtectionFlagsUnionUnion? anonymous = null,
            uint? value = null,
            uint? protectionEnabled = null,
            uint? overlayOrFullscreenRequired = null,
            uint? reserved = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }

            if (protectionEnabled is not null)
            {
                ProtectionEnabled = protectionEnabled.Value;
            }

            if (overlayOrFullscreenRequired is not null)
            {
                OverlayOrFullscreenRequired = overlayOrFullscreenRequired.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d9types_L2102_C9")]
        [NativeName("Name", "anonymous1")]
        public AuthenticatedchannelProtectionFlagsUnionUnion Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Value")]
        public uint Value;

        public ref uint ProtectionEnabled
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.ProtectionEnabled;
        }

        public ref uint OverlayOrFullscreenRequired
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.OverlayOrFullscreenRequired;
        }

        public ref uint Reserved
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Reserved;
        }
    }
}
