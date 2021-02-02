// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Initialization hints are set before <see cref="IGlfw.Init" /> and affect how the library behaves until termination.
    /// Hints are set with <see cref="InitHint" />.
    /// </summary>
    public enum InitHint
    {
        /// <summary>
        /// Used to specify whether to also expose joystick hats as buttons,
        /// for compatibility with earlier versions of GLFW that did not have
        /// <see cref="IGlfw.GetJoystickHats" />.
        /// Set this with <see cref="InitHint" />.
        /// </summary>
        JoystickHatButtons = 0x00050001
    }
}