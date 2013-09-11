using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Windows.Forms;
using ExposedObject;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.UserNotifications.Interop;
using Reddit;

namespace KevinBoyle.UserNotificationDemo
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(GuidList.guidUserNotificationDemoPkgString)]
    public sealed class UserNotificationDemoPackage : Package
    {
        protected override void Initialize()
        {
            base.Initialize();

            OleMenuCommandService mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if ( null != mcs )
            {
                mcs.AddCommand(new MenuCommand(MenuItemCallback, new CommandID(GuidList.guidUserNotificationDemoCmdSet, (int)PkgCmdIDList.cmdidShowNotification) ) );
            }
        }

        private void MenuItemCallback(object sender, EventArgs e)
        {
            var notificationService = (IVsUserNotificationsService)GetService(typeof(SVsUserNotificationsService));

            var notifcationManager = notificationService.GetUserNotificationsManagerAsync().GetResult();

            var vsUserNotificationsManager = (IVsUserNotificationsManager) notifcationManager;

            var pic = new RedditPicProvider().GetAwwPicture();
            
            vsUserNotificationsManager.AddUserNotification(ExampleProvider.Guid, pic.Url, pic.Title, pic.Url, (uint) NotificationServerity.Critical, isTransient: true);

            RegisterNotificationProvider(vsUserNotificationsManager);
        }

        /// <summary>
        /// Ideally, I would register this using the MEF Export, but that isn't working and I'm not sure why...
        /// 
        /// This also has the issue that any persisted notifications won't have their provider hooked up on next launch
        /// </summary>
        private static void RegisterNotificationProvider(IVsUserNotificationsManager vsUserNotificationsManager)
        {
            var exposedManager = Exposed.From(vsUserNotificationsManager);

            var notificationsProviders = (IDictionary<Guid, IVsUserNotificationsProvider>) exposedManager.NotificationsProviders;

            notificationsProviders[ExampleProvider.Guid] = new ExampleProvider();
        }
    }
}
