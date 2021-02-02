// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents which API the graphics context should use.
    /// </summary>
    public enum ContextAPI
    {
        /// <summary>
        /// Don't use any API. This is necessary for linking an external API, such as Vulkan, to the window.
        /// </summary>
        None = 0,

        /// <summary>
        /// Use Vulkan. Silk.NET doesn't support this yet.
        /// </summary>
        Vulkan
    }
}
