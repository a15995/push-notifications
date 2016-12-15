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
    public class NotificationBuilder
    {
        // Instantiate the builder and set notification elements:
        Notification.Builder builder = new Notification.Builder(this)
            .SetContentTitle("Sample Notification")
            .SetContentText("Hello World! This is my first notification!")
            .SetSmallIcon(Resource.Drawable.ic_notification);

        // Build the notification:
        Notification notification = builder.Build();

        // Get the notification manager:
        NotificationManager notificationManager =
            GetSystemService(Context.NotificationService) as NotificationManager;

        // Publish the notification:
        const int notificationId = 0;
        notificationManager.Notify (notificationId, notification);
    }
}