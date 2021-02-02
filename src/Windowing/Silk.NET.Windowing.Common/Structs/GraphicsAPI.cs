// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing
{
    /// <summary>
    ///   Represents the context API, and associated configuration, that the window should use.
    /// </summary>
    /// <remarks>
    ///   By default, this struct uses DirectX 12.
    /// </remarks>
    public struct GraphicsAPI
    {
        /// <summary>
        ///   Gets or sets the rendering API to use.
        /// </summary>
        public ContextAPI API { get; set; }

        /// <summary>
        ///   Gets or sets the options to use for creation of the graphics context.
        /// </summary>
        public ContextFlags Flags { get; set; }

        /// <summary>
        ///   Gets or sets the version of the API to use.
        /// </summary>
        public APIVersion Version { get; set; }

        /// <summary>
        ///   Create a new instance of the <see cref="GraphicsAPI"/> struct.
        /// </summary>
        /// <param name="api">The context API to use.</param>
        /// <param name="flags">The context flags to use.</param>
        /// <param name="apiVersion">The API version to use.</param>
        public GraphicsAPI(ContextAPI api, APIVersion apiVersion, ContextFlags flags)
        {
            API = api;
            Version = apiVersion;
            Flags = flags;
        }

        /// <summary>
        ///   Gets the default graphics API. This is DirectX 12.
        /// </summary>
        public static GraphicsAPI Default => new GraphicsAPI
        (
            ContextAPI.DirectX,
            new APIVersion(12, 0),
            ContextFlags.Default
        );

        /// <summary>
        ///   Gets a <see cref="GraphicsAPI"/> representing no specific graphics API.
        /// </summary>
        public static GraphicsAPI None => default;
    }
}
