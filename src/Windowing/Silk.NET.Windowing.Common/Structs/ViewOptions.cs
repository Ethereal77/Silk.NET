// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    ///   Contains all view properties, used for view creation.
    /// </summary>
    public struct ViewOptions : IViewProperties
    {
        /// <inheritdoc />
        public bool ShouldSwapAutomatically { get; set; }

        /// <inheritdoc />
        public bool IsEventDriven { get; set; }

        /// <inheritdoc />
        Vector2D<int> IViewProperties.Size
            => throw new InvalidOperationException("Can't get the size of a non-existent view.");

        /// <inheritdoc />
        public double FramesPerSecond { get; set; }

        /// <inheritdoc />
        public double UpdatesPerSecond { get; set; }

        /// <inheritdoc />
        public GraphicsAPI API { get; set; }

        /// <inheritdoc />
        public bool VSync { get; set; }

        /// <inheritdoc />
        public VideoMode VideoMode { get; set; }

        /// <inheritdoc />
        public int? PreferredDepthBufferBits { get; set; }

        /// <inheritdoc />
        public int? PreferredStencilBufferBits { get; }

        /// <inheritdoc />
        public Vector4D<int>? PreferredBitDepth { get; }

        /// <summary>
        ///   Creates a new <see cref="ViewOptions"/> struct.
        /// </summary>
        public ViewOptions
        (
            double framesPerSecond,
            double updatesPerSecond,
            GraphicsAPI api,
            bool isVSync,
            bool shouldSwapAutomatically,
            VideoMode videoMode,
            int? preferredDepthBufferBits = null,
            int? preferredStencilBufferBits = null,
            Vector4D<int>? preferredBitDepth = null,
            bool isEventDriven = false
        )
        {
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            ShouldSwapAutomatically = shouldSwapAutomatically;
            VideoMode = videoMode;
            PreferredDepthBufferBits = preferredDepthBufferBits;
            PreferredStencilBufferBits = preferredStencilBufferBits;
            PreferredBitDepth = preferredBitDepth;
            IsEventDriven = isEventDriven;
            VSync = isVSync;
        }

        /// <summary>
        ///   Creates a new <see cref="ViewOptions"/> struct from the given <see cref="WindowOptions"/>.
        /// </summary>
        /// <param name="opts">The window options to copy.</param>
        public ViewOptions(WindowOptions opts)
        {
            FramesPerSecond = opts.FramesPerSecond;
            UpdatesPerSecond = opts.UpdatesPerSecond;
            API = opts.API;
            VideoMode = opts.VideoMode;
            PreferredDepthBufferBits = opts.PreferredDepthBufferBits;
            PreferredStencilBufferBits = opts.PreferredStencilBufferBits;
            PreferredBitDepth = opts.PreferredBitDepth;
            ShouldSwapAutomatically = opts.ShouldSwapAutomatically;
            IsEventDriven = opts.IsEventDriven;
            VSync = opts.VSync;
        }

        /// <summary>
        ///   Represents a <see cref="ViewOptions"/> with sensible defaults.
        /// </summary>
        public static ViewOptions Default { get; } = new ViewOptions
        (
            framesPerSecond: 0.0,
            updatesPerSecond: 0.0,
            GraphicsAPI.Default,
            isVSync: false,
            shouldSwapAutomatically: false,
            videoMode: VideoMode.Default
        );
    }
}
