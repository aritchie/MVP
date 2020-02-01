﻿using Android.App;
using Android.Content;
using Android.OS;

namespace MVP.Droid
{
    [Activity(Label = "CallbackInterceptorActivity")]
    [IntentFilter(
        new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
        DataScheme = "com.microsoft.mvp",
        DataHost = "callback")]
    public class CallbackInterceptorActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            MainActivity.CustomUrlSchemeCallbackHandler(Intent.DataString);
            MainActivity.CustomUrlSchemeCallbackHandler = null;

            Finish();
        }
    }
}
