using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.UserNotifications.Interop
{
    [ComImport, TypeIdentifier, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("791A7AEF-BFFD-45E8-B164-FC8CDD423D69"), CompilerGenerated]
    public interface IVsUserNotification
    {
        Guid Provider { get; }
        string Identifier { [return: MarshalAs(UnmanagedType.BStr)] get; }
        string Title { [return: MarshalAs(UnmanagedType.BStr)] get; [param: In, MarshalAs(UnmanagedType.BStr)] set; }
        string Description { [return: MarshalAs(UnmanagedType.BStr)] get; [param: In, MarshalAs(UnmanagedType.BStr)] set; }
        uint Severity { get; }
        object Context { [return: MarshalAs(UnmanagedType.Struct)] get; [param: In, MarshalAs(UnmanagedType.Struct)] set; }
        DateTime Creation { get; }
        DateTime Expiration { get; }
        uint State { get; }
    }
}