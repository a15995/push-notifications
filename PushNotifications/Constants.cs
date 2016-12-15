using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PushNotifications
{
    public static class Constants
    {
        public const string SenderID = "274906423505"; // Google API Project Number
        public const string ListenConnectionString = "Endpoint=sb://sorensnotificationnamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=LH0ql+BUULTPiG6GXVf0hyu4yx3NDh+GK68+O+gojoM=";
        public const string NotificationHubName = "sorensnotificationhub";
    }
}