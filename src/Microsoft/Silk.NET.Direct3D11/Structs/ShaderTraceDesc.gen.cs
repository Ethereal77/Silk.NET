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
    [NativeName("Name", "D3D11_SHADER_TRACE_DESC")]
    public unsafe partial struct ShaderTraceDesc
    {
        public ShaderTraceDesc
        (
            ShaderType? type = null,
            uint? flags = null,
            ShaderTraceDescUnion? anonymous = null,
            VertexShaderTraceDesc? vertexShaderTraceDesc = null,
            HullShaderTraceDesc? hullShaderTraceDesc = null,
            DomainShaderTraceDesc? domainShaderTraceDesc = null,
            GeometryShaderTraceDesc? geometryShaderTraceDesc = null,
            PixelShaderTraceDesc? pixelShaderTraceDesc = null,
            ComputeShaderTraceDesc? computeShaderTraceDesc = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (vertexShaderTraceDesc is not null)
            {
                VertexShaderTraceDesc = vertexShaderTraceDesc.Value;
            }

            if (hullShaderTraceDesc is not null)
            {
                HullShaderTraceDesc = hullShaderTraceDesc.Value;
            }

            if (domainShaderTraceDesc is not null)
            {
                DomainShaderTraceDesc = domainShaderTraceDesc.Value;
            }

            if (geometryShaderTraceDesc is not null)
            {
                GeometryShaderTraceDesc = geometryShaderTraceDesc.Value;
            }

            if (pixelShaderTraceDesc is not null)
            {
                PixelShaderTraceDesc = pixelShaderTraceDesc.Value;
            }

            if (computeShaderTraceDesc is not null)
            {
                ComputeShaderTraceDesc = computeShaderTraceDesc.Value;
            }
        }


        [NativeName("Type", "D3D11_SHADER_TYPE")]
        [NativeName("Type.Name", "D3D11_SHADER_TYPE")]
        [NativeName("Name", "Type")]
        public ShaderType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11shadertracing_L126_C5")]
        [NativeName("Name", "anonymous1")]
        public ShaderTraceDescUnion Anonymous;

        public ref VertexShaderTraceDesc VertexShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.VertexShaderTraceDesc;
        }

        public ref HullShaderTraceDesc HullShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.HullShaderTraceDesc;
        }

        public ref DomainShaderTraceDesc DomainShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.DomainShaderTraceDesc;
        }

        public ref GeometryShaderTraceDesc GeometryShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.GeometryShaderTraceDesc;
        }

        public ref PixelShaderTraceDesc PixelShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.PixelShaderTraceDesc;
        }

        public ref ComputeShaderTraceDesc ComputeShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.ComputeShaderTraceDesc;
        }
    }
}
