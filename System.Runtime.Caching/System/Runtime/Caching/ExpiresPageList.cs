﻿namespace System.Runtime.Caching
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct ExpiresPageList
    {
        internal int _head;
        internal int _tail;
    }
}

