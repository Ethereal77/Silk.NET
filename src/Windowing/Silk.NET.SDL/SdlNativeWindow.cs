﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.SDL
{
    public struct SdlNativeWindow : INativeWindow
    {
        public unsafe SdlNativeWindow(Sdl api, Window* window) : this()
        {
            Kind = NativeWindowFlags.Sdl;
            Sdl = (nint) window;
            SysWMInfo info;
            api.GetWindowWMInfo(window, &info);
            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (info.Subsystem)
            {
                case SysWMType.OS2:
                    Kind |= NativeWindowFlags.OS2;
                    break;
                case SysWMType.Haiku:
                    Kind |= NativeWindowFlags.Haiku;
                    break;
                case SysWMType.DirectFB:
                    Kind |= NativeWindowFlags.DirectFB;
                    break;
                case SysWMType.Mir:
                case SysWMType.Unknown:
                    break;
                case SysWMType.Windows:
                {
                    Kind |= NativeWindowFlags.Win32;
                    Win32 = (info.Info.Win.Hwnd, info.Info.Win.HDC, info.Info.Win.HInstance);
                    break;
                }
                case SysWMType.X11:
                {
                    Kind |= NativeWindowFlags.X11;
                    X11 = ((nint) info.Info.X11.Display, (nuint) info.Info.X11.Window);
                    break;
                }
                case SysWMType.Cocoa:
                {
                    Kind |= NativeWindowFlags.Cocoa;
                    Cocoa = (nint) info.Info.Cocoa.Window;
                    break;
                }
                case SysWMType.UIKit:
                {
                    Kind |= NativeWindowFlags.UIKit;
                    UIKit = ((nint) info.Info.UIKit.Window,
                        info.Info.UIKit.Framebuffer,
                        info.Info.UIKit.Colorbuffer,
                        info.Info.UIKit.ResolveFramebuffer);
                    break;
                }
                case SysWMType.Wayland:
                {
                    Kind |= NativeWindowFlags.Wayland;
                    Wayland = ((nint) info.Info.Wayland.Display, (nint) info.Info.Wayland.Surface);
                    break;
                }
                case SysWMType.WinRT:
                {
                    Kind |= NativeWindowFlags.WinRT;
                    WinRT = (nint) info.Info.WinRT.Window;
                    break;
                }
                case SysWMType.Vivante:
                {
                    Kind |= NativeWindowFlags.Vivante;
                    Vivante = ((nint) info.Info.Vivante.Display, (nint) info.Info.Vivante.Window);
                    break;
                }
            }
        }

        public NativeWindowFlags Kind { get; }
        public (nint Display, nuint Window)? X11 { get; }
        public nint? Cocoa { get; }
        public (nint Display, nint Surface)? Wayland { get; }
        public nint? WinRT { get; }
        public (nint Window, uint Framebuffer, uint Colorbuffer, uint ResolveFramebuffer)? UIKit { get; }
        public (nint Hwnd, nint HDC, nint HInstance)? Win32 { get; }
        public (nint Display, nint Window)? Vivante { get; }
        public nint? Glfw { get; }
        public nint? Sdl { get; }
    }
}
