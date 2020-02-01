using System;
using Android.App;
using Android.Runtime;
using Shiny;


namespace MVP.Droid
{
    [Application]
    public class MainApplication : ShinyAndroidApplication<Startup>
    {
        protected MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}
