// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Contexts;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl
{
    /// <summary>
    /// Contains utility methods for working with the SDL windowing backend.
    /// </summary>
    public static class SdlWindowing
    {
        /// <summary>
        /// Registers this platform with the <see cref="Window"/> class so that the <see cref="Window.Create"/> method
        /// may be used to create SDL windows.
        /// </summary>
        public static void RegisterPlatform() => SdlPlatform.GetOrRegister();

        /// <summary>
        /// Prioritizes the SDL windowing platform over others.
        /// </summary>
        public static void Use() => Window.PrioritizeSdl();

        /// <summary>
        /// Gets a value indicating whether the given view is an SDL view.
        /// </summary>
        /// <returns>Whether the given view is an SDL view.</returns>
        public static bool IsViewSdl(IView view) => view is SdlView;

        public static SDL.Sdl? GetExistingApi(IView view) => (view as SdlView)?.Sdl;

        public static unsafe SysWMInfo? GetSysWMInfo(IView view)
        {
            if (view is SdlView sdlView)
            {
                SysWMInfo ret;
                if (sdlView.Sdl.GetWindowWMInfo(sdlView.SdlWindow, &ret))
                {
                    return ret;
                }
            }
            
            return null;
        }

        public static unsafe Silk.NET.SDL.Window* GetHandle(IView view)
            => view is SdlView sdlView ? sdlView.SdlWindow : null;
    }
}
