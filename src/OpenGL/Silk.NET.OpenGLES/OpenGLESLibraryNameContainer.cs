// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGLES
{
    /// <summary>
    /// Contains the library name of OpenGLES.
    /// </summary>
    internal class OpenGLESLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Windows64 => "libGLESv2.dll";

        /// <inheritdoc />
        public override string Windows86 => "libGLESv2.dll";
    }
}
