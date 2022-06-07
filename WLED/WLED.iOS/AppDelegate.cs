using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Intents;
using ObjCRuntime;
using UIKit;

namespace WLED.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            Console.WriteLine("five");

            return base.FinishedLaunching(app, options);
        }

        public override void UserActivityUpdated(UIApplication application, NSUserActivity userActivity)
        {
            base.UserActivityUpdated(application, userActivity); //?

            Console.WriteLine(userActivity.ActivityType);
            var a = 5;
        }

        public override void HandleIntent(UIApplication application, INIntent intent, Action<INIntentResponse> completionHandler)
        {
            base.HandleIntent(application, intent, completionHandler);

            Console.WriteLine("made");
            var a = 5;
        }

        public override bool WillContinueUserActivity(UIApplication application, string userActivityType)
        {
            Console.WriteLine(userActivityType);
            return false;
            //return base.WillContinueUserActivity(application, userActivityType);
        }
    }
}
