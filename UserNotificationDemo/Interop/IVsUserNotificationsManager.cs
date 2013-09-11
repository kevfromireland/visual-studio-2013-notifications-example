using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.UserNotifications.Interop
{
    [ComImport, TypeIdentifier, CompilerGenerated, Guid("730A0F1D-66C9-4FFB-A762-EA05BAA715EB"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVsUserNotificationsManager
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        IVsUserNotification AddUserNotification([In] Guid Provider, [In, MarshalAs(UnmanagedType.LPWStr)] string Identifier, [In, MarshalAs(UnmanagedType.LPWStr)] string Title, [In, MarshalAs(UnmanagedType.LPWStr)] string Description, [In] uint Severity, [In, Optional, MarshalAs(UnmanagedType.Struct)] object Context, [In, Optional] DateTime Expiration, [In] bool isTransient = false);
        bool RemoveUserNotification([In, MarshalAs(UnmanagedType.Interface)] IVsUserNotification notification);
        void PromoteUserNotification([In, MarshalAs(UnmanagedType.Interface)] IVsUserNotification notification, [In] uint Severity);
        [return: MarshalAs(UnmanagedType.Interface)]
        IVsEnumUserNotifications GetUserNotifications([In] Guid Provider, [In, Optional] uint filter, [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string Identifier);
    }
}