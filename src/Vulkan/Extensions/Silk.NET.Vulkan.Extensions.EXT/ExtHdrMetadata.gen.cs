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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_hdr_metadata")]
    public unsafe partial class ExtHdrMetadata : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_hdr_metadata";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        public unsafe partial void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainKHR* pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] HdrMetadataEXT* pMetadata);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        public unsafe partial void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainKHR* pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in HdrMetadataEXT pMetadata);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        public unsafe partial void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in SwapchainKHR pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] HdrMetadataEXT* pMetadata);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        public partial void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in SwapchainKHR pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] in HdrMetadataEXT pMetadata);

        public ExtHdrMetadata(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

