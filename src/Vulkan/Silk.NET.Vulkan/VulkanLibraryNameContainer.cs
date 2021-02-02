// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan
{
    /// <summary>
    /// Contains the library name of Vulkan.
    /// </summary>
    internal class VulkanLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Windows64 => "vulkan-1.dll";

        /// <inheritdoc />
        public override string Windows86 => "vulkan-1.dll";
    }
}
