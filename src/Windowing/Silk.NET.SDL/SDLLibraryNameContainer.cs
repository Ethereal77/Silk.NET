// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.SDL
{
    /// <summary>
    /// Contains the library name of SDL.
    /// </summary>
    internal class SDLLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Windows64 => "SDL2.dll";

        /// <inheritdoc />
        public override string Windows86 => "SDL2.dll";
    }
}
