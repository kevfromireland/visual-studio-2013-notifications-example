using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.VisualStudio.UserNotifications.Interop
{
    [ComImport, TypeIdentifier, CompilerGenerated, Guid("BB699853-3885-49C2-A17F-D9E18B76782F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVsUserNotificationsService
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        IVsTask GetUserNotificationsManagerAsync();
    }
}