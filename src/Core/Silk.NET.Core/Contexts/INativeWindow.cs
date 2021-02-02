﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Contexts
{
    /// <summary>
    /// Wraps any underlying native window handles a window (or window-like instance) may have. 
    /// </summary>
    public interface INativeWindow
    {
        /// <summary>
        /// Gets a bitmask enum representing the underlying platforms powering this window.
        /// </summary>
        public NativeWindowFlags Kind { get; }

        /// <summary>
        /// The WinRT window's inspectable interface (IInspectable*). May be null, in which case the underlying window
        /// is not using WinRT.
        /// </summary>
        nint? WinRT { get; }

        /// <summary>
        /// The Win32 window handle (HWND), display controller (HDC), and instance (HINSTANCE). May be null, in which
        /// case the underlying window is not using Win32.
        /// </summary>
        (nint Hwnd, nint HDC, nint HInstance)? Win32 { get; }

        /// <summary>
        /// The Vivante EGL display type (EGLNativeDisplayType) and EGL window type (EGLNativeWindowType). May be null,
        /// in which case the underlying window is not using Vivante.
        /// </summary>
        (nint Display, nint Window)? Vivante { get; }

        /// <summary>
        /// The GLFW window handle (GLFWwindow* or WindowHandle* if using Silk.NET.GLFW). May be null, in which case the
        /// underlying window is not using GLFW.
        /// </summary>
        nint? Glfw { get; }

        /// <summary>
        /// The SDL window handle (SDL_Window* or Window* if using Silk.NET.SDL). May be null, in which case the
        /// underlying window is not using SDL.
        /// </summary>
        nint? Sdl { get; }
    }
}