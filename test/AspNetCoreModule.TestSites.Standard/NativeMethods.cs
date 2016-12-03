﻿using System;
using System.Runtime.InteropServices;

namespace AspnetCoreModule.TestSites.Standard
{
    internal class NativeMethods
    {
#if DOTNET5_4
        private const string api_ms_win_core_handle_LIB = "api-ms-win-core-handle-l1-1-0.dll";
#else
        private const string KERNEL32 = "kernel32.dll";
#endif

#if DOTNET5_4
        [DllImport(api_ms_win_core_handle_LIB, ExactSpelling = true, SetLastError = true)]
#else
        [DllImport(KERNEL32, ExactSpelling = true, SetLastError = true)]
#endif
        internal static extern bool CloseHandle(IntPtr handle);
    }
}