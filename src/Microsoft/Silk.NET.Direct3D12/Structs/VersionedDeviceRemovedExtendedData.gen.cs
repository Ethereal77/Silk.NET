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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA")]
    public unsafe partial struct VersionedDeviceRemovedExtendedData
    {
        public VersionedDeviceRemovedExtendedData
        (
            DredVersion? version = null,
            VersionedDeviceRemovedExtendedDataUnion? anonymous = null,
            DeviceRemovedExtendedData? dred10 = null,
            DeviceRemovedExtendedData1? dred11 = null,
            DeviceRemovedExtendedData2? dred12 = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (dred10 is not null)
            {
                Dred10 = dred10.Value;
            }

            if (dred11 is not null)
            {
                Dred11 = dred11.Value;
            }

            if (dred12 is not null)
            {
                Dred12 = dred12.Value;
            }
        }


        [NativeName("Type", "D3D12_DRED_VERSION")]
        [NativeName("Type.Name", "D3D12_DRED_VERSION")]
        [NativeName("Name", "Version")]
        public DredVersion Version;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L13459_C5")]
        [NativeName("Name", "anonymous1")]
        public VersionedDeviceRemovedExtendedDataUnion Anonymous;

        public ref DeviceRemovedExtendedData Dred10
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Dred10;
        }

        public ref DeviceRemovedExtendedData1 Dred11
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Dred11;
        }

        public ref DeviceRemovedExtendedData2 Dred12
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Dred12;
        }
    }
}
