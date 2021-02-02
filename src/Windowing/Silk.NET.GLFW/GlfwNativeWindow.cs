// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;

namespace Silk.NET.GLFW
{
    public struct GlfwNativeWindow : INativeWindow
    {
        private const int GwlpHInstance = -6;
    
        [DllImport("user32", EntryPoint = "GetDC")]
        private static extern nint Win32GetDC(nint hwnd);

        [DllImport("user32", EntryPoint = "GetWindowLongPtrA")]
        private static extern nint Win32GetWindowLongPtr(nint hwnd, int index);
    
        public unsafe GlfwNativeWindow(Glfw api, WindowHandle* window) : this()
        {
            Kind |= NativeWindowFlags.Glfw;
            Glfw = (nint) window;
            var getHwnd = api.Context.GetProcAddress("glfwGetWin32Window");
            if (getHwnd != default)
            {
                var hwnd = ((delegate* unmanaged[Cdecl]<WindowHandle*, nint>) getHwnd)(window);
                Kind |= NativeWindowFlags.Win32;
                Win32 = (hwnd, Win32GetDC(hwnd), Win32GetWindowLongPtr(hwnd, GwlpHInstance));
                return;
            }
        }
        public NativeWindowFlags Kind { get; }
        public nint? WinRT { get; }
        public (nint Hwnd, nint HDC, nint HInstance)? Win32 { get; }
        public (nint Display, nint Window)? Vivante { get; }
        public nint? Glfw { get; }
        public nint? Sdl { get; }
    }
}
