// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing
{
    /// <summary>
    ///   Defines flags related to the creation of a graphics context.
    /// </summary>
    [Flags]
    public enum ContextFlags
    {
        /// <summary>
        ///   No flags specified.
        /// </summary>
        Default = 0,

        /// <summary>
        ///   Enables debug context, providing more debugging information, although it can run slower.
        /// </summary>
        Debug = 1
    }
}
