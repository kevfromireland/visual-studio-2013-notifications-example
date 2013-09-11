using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.UserNotifications.Interop
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), TypeIdentifier, CompilerGenerated, Guid("2E1641C7-2959-4962-949C-6388375D6B29")]
    public interface IVsEnumUserNotifications
    {
        [PreserveSig]
        int Next([In] uint celt, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 0)] IVsUserNotification[] rgelt, out uint pceltFetched);
        [PreserveSig]
        int Skip([In] uint celt);
        void Reset();
        void Clone([MarshalAs(UnmanagedType.Interface)] out IVsEnumUserNotifications ppEnum);
    }
}