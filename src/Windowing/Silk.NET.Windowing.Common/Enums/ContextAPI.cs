// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing
{
    /// <summary>
    ///   Represents which API the graphics context should use.
    /// </summary>
    /// <remarks>
    ///   This is necessary for linking an external API, such as DirectX 12, to a window.
    /// </remarks>
    public enum ContextAPI
    {
        /// <summary>
        ///   Don't use any API.
        /// </summary>
        None = 0,

        /// <summary>
        ///   Use DirectX.
        /// </summary>
        DirectX = 1
    }
}
