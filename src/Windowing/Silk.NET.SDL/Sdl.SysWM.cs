// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;

namespace Silk.NET.SDL
{
    public enum SysWMType
    {
        Unknown,
        Windows,
        DirectFB,
        Mir, /* no longer available, left for API/ABI compatibility. Remove in 2.1! */
        WinRT,
        Vivante,
        OS2,
        Haiku
    }

    public struct SysWMMsg
    {
        public Version Version;
        public SysWMType Subsystem;
        public SysWMMsgValue Msg;
    };

    public struct SysWMMsgWindows
    {
        public nint hwnd;

        /**< The window for the message */
        public uint Msg;

        /**< The type of message */
        public nuint WParam;

        /**< WORD message parameter */
        public nint LParam; /**< LONG message parameter */
    }

    public struct SysWMMsgDummy
    {
        public int Dummy;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SysWMMsgValue
    {
        [FieldOffset(0)] public SysWMMsgWindows Win;
        [FieldOffset(0)] public SysWMMsgDummy Vivante;
        [FieldOffset(0)] public int Dummy;
    }

    /**
         *  The custom window manager information structure.
         *
         *  When this structure is returned, it holds information about which
         *  low level system it is using, and will be one of SDL_SYSWM_TYPE.
         */
    public struct SysWMInfo
    {
        public Version Version;
        public SysWMType Subsystem;
        public SysWMInfoValue Info;
    };

    [StructLayout(LayoutKind.Explicit)]
    public struct SysWMInfoValue
    {
        [FieldOffset(0)] public SysWMInfoWindows Win;
        [FieldOffset(0)] public SysWMInfoWinRT WinRT;
        [FieldOffset(0)] public SysWMInfoMir Mir;
        [FieldOffset(0)] public SysWMInfoVivante Vivante;

        /* Make sure this union is always 64 bytes (8 64-bit pointers). */
        /* Be careful not to overflow this if you add a new target! */
        [FieldOffset(0)] public unsafe fixed byte Dummy[64];
    }

    public struct SysWMInfoWinRT
    {
        // TODO consider making this an IUnknown when DirectX is in?
        public unsafe void* Window; /**< The WinRT CoreWindow */
    }

    public struct SysWMInfoMir
    {
        public unsafe void* Connection;

        /**< Mir display server connection */
        public unsafe void* Surface; /**< Mir surface */
    }

    public struct SysWMInfoWindows
    {
        public nint Hwnd;

        /**< The window handle */
        public nint HDC;

        /**< The window device context */
        public nint HInstance; /**< The instance handle */
    }

    public struct SysWMInfoVivante
    {
        public unsafe void* Display;
        public unsafe void* Window;
    }

// TODO This is currently integrated in Sdl.gen.cs but it should not be because BuildTools will overwrite it in there.
//      Because of a bug, SilkTouch currently can't handle multiple partials and is pending fixup
#if false
    partial class Sdl
    {
        /* Function prototypes */
        /**
         *  \brief This function allows access to driver-dependent window information.
         *
         *  \param window The window about which information is being requested
         *  \param info This structure must be initialized with the SDL version, and is
         *              then filled in with information about the given window.
         *
         *  \return SDL_TRUE if the function is implemented and the version member of
         *          the \c info struct is valid, SDL_FALSE otherwise.
         *
         *  You typically use this function like this:
         *  \code
         *  SDL_SysWMinfo info;
         *  SDL_VERSION(&info.version);
         *  if ( SDL_GetWindowWMInfo(window, &info) ) { ... }
         *  \endcode
         */
        [NativeApi(EntryPoint = "SDL_GetWindowWMInfo")]
        public unsafe partial bool GetWindowWMInfo(Window* window, SysWMInfo* info);
    }
#endif
}
