﻿namespace System.Deployment.Internal.Isolation
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct CATEGORY_SUBCATEGORY
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string Subcategory;
    }
}

