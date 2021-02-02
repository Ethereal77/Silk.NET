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
    [NativeName("Name", "D3D11_BUFFER_RTV")]
    public unsafe partial struct BufferRtv
    {
        public BufferRtv
        (
            BufferRtvUnion1? anonymous1 = null,
            BufferRtvUnion2? anonymous2 = null,
            uint? firstElement = null,
            uint? elementOffset = null,
            uint? numElements = null,
            uint? elementWidth = null
        ) : this()
        {
            if (anonymous1 is not null)
            {
                Anonymous1 = anonymous1.Value;
            }

            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
            }

            if (firstElement is not null)
            {
                FirstElement = firstElement.Value;
            }

            if (elementOffset is not null)
            {
                ElementOffset = elementOffset.Value;
            }

            if (numElements is not null)
            {
                NumElements = numElements.Value;
            }

            if (elementWidth is not null)
            {
                ElementWidth = elementWidth.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L3745_C5")]
        [NativeName("Name", "anonymous1")]
        public BufferRtvUnion1 Anonymous1;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L3750_C5")]
        [NativeName("Name", "anonymous2")]
        public BufferRtvUnion2 Anonymous2;

        public ref uint FirstElement
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous1.FirstElement;
        }

        public ref uint ElementOffset
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous1.ElementOffset;
        }

        public ref uint NumElements
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous2.NumElements;
        }

        public ref uint ElementWidth
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous2.ElementWidth;
        }
    }
}
