// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class OpenALLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Windows86 => "openal32.dll";

        /// <inheritdoc />
        public override string Windows64 => "openal32.dll";
    }
}