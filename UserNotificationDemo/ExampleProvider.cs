using System;
using System.ComponentModel.Composition;
using System.Diagnostics;
using Microsoft.VisualStudio.UserNotifications.Interop;

namespace KevinBoyle.UserNotificationDemo
{
    [Export(typeof(IVsUserNotificationsProvider))]
    public class ExampleProvider : IVsUserNotificationsProvider
    {
        public static Guid Guid
        {
            get { return new Guid("00BAA539-B1E1-49E2-ABD1-8BD073AC8181"); }
        }

        public Guid ID
        {
            get { return Guid; }
        }

        public bool OnClick(IVsUserNotification notification)
        {
            Process.Start(notification.Identifier);
            return true;
        }

        public void OnDismiss(IVsUserNotification notification)
        {
        }

        public void OnExpire(IVsUserNotification notification)
        {
        }

        public void Refresh(uint LCID)
        {
        }
    }
}