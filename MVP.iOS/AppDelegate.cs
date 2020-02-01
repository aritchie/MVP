﻿using System;
using Foundation;
using Shiny;
using Shiny.Jobs;
using UIKit;

namespace MVP.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public static Action<string> CallbackHandler { get; set; }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            iOSShinyHost.Init(new Startup());
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }


        public override void PerformFetch(UIApplication application, Action<UIBackgroundFetchResult> completionHandler)
            => JobManager.OnBackgroundFetch(completionHandler);
            
        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
        {
            CallbackHandler(url.AbsoluteString);
            CallbackHandler = null;
            return true;
        }
    }
}
