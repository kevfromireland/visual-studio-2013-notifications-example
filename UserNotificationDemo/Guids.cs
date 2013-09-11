// Guids.cs
// MUST match guids.h
using System;

namespace KevinBoyle.UserNotificationDemo
{
    static class GuidList
    {
        public const string guidUserNotificationDemoPkgString = "05965589-a481-45ca-9ee1-9dde06bd0613";
        public const string guidUserNotificationDemoCmdSetString = "14959277-b68c-4093-ad24-4f2a95c1fc1d";

        public static readonly Guid guidUserNotificationDemoCmdSet = new Guid(guidUserNotificationDemoCmdSetString);
    };
}