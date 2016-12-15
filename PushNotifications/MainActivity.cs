using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using Gcm.Client;

namespace PushNotifications
{
    [Activity(Label = "PushNotifications", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static MainActivity instance; // Add an instance variable to the MainActivity class that will be used to show an alert dialog when the app is running

        protected override void OnCreate(Bundle bundle) // In the OnCreate method of MainActivity.cs, initialize the instance variable and add a call to RegisterWithGCM
        {
            instance = this;

            base.OnCreate(bundle);

            // Set your view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get your button from the layout resource,
            // and attach an event to it
            
        }

        private void RegisterWithGCM() // Create the following method in the MainActivity class
        {
            // Check to ensure everything's set up right
            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);

            // Register for push notifications
            Log.Info("MainActivity", "Registering...");
            GcmClient.Register(this, Constants.SenderID);
        }
    }
}

