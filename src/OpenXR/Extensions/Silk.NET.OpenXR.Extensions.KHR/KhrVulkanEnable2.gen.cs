// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_vulkan_enable2")]
    public unsafe partial class KhrVulkanEnable2 : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_vulkan_enable2";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanDeviceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public unsafe partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanDeviceKHR")]
        public partial Result CreateVulkanDevice([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanDeviceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanDevice, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanInstanceCreateInfoKHR* createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public unsafe partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] uint* vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateVulkanInstanceKHR")]
        public partial Result CreateVulkanInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanInstanceCreateInfoKHR createInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanInstance, [Count(Count = 0)] ref uint vulkanResult);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR")]
        public unsafe partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanGraphicsDeviceGetInfoKHR* getInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanPhysicalDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR")]
        public unsafe partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] VulkanGraphicsDeviceGetInfoKHR* getInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanPhysicalDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR")]
        public unsafe partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanGraphicsDeviceGetInfoKHR getInfo, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vulkanPhysicalDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDevice2KHR")]
        public partial Result GetVulkanGraphicsDevice2([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in VulkanGraphicsDeviceGetInfoKHR getInfo, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vulkanPhysicalDevice);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirements2KHR")]
        public unsafe partial Result GetVulkanGraphicsRequirements2([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsVulkanKHR* graphicsRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirements2KHR")]
        public partial Result GetVulkanGraphicsRequirements2([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsVulkanKHR graphicsRequirements);

        public KhrVulkanEnable2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}
