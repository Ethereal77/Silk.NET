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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC")]
    public unsafe partial struct VideoProcessorOutputViewDesc
    {
        public VideoProcessorOutputViewDesc
        (
            VpovDimension? viewDimension = null,
            VideoProcessorOutputViewDescUnion? anonymous = null,
            Tex2DVpov? texture2D = null,
            Tex2DArrayVpov? texture2DArray = null
        ) : this()
        {
            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }
        }


        [NativeName("Type", "D3D11_VPOV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_VPOV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public VpovDimension ViewDimension;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L11546_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoProcessorOutputViewDescUnion Anonymous;

        public ref Tex2DVpov Texture2D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Texture2D;
        }

        public ref Tex2DArrayVpov Texture2DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Texture2DArray;
        }
    }
}
