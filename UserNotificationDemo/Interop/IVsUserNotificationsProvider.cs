using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.UserNotifications.Interop
{
    [ComImport, CompilerGenerated, Guid("1A60AACF-11E6-4591-BF1C-66B0BD42D48F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), TypeIdentifier]
    public interface IVsUserNotificationsProvider
    {
        Guid ID { get; }
        bool OnClick([In, MarshalAs(UnmanagedType.Interface)] IVsUserNotification notification);
        void OnDismiss([In, MarshalAs(UnmanagedType.Interface)] IVsUserNotification notification);
        void OnExpire([In, MarshalAs(UnmanagedType.Interface)] IVsUserNotification notification);
        void Refresh([In] uint LCID);
    }
}