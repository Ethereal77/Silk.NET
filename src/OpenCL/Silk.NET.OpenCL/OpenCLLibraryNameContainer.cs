// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Loader;

namespace Silk.NET.OpenCL
{
    /// <summary>
    /// Contains the library name of OpenCL.
    /// </summary>
    internal class OpenCLLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string Windows64 => "opencl.dll";

        /// <inheritdoc />
        public override string Windows86 => "opencl.dll";
    }
}
