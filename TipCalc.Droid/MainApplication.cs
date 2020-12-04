using System;
using Android.App;
using Android.Runtime;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Core;

//IMPORTANT!!!! -> IT IS MVVMCROSS  6.0.0 VER. THE LATEST VERSION DOESN'T CONTAIN PLATFORM.ANDROID NAMESPACES :<
namespace TipCalc.Droid
{
    [Application]
    /*
     * MvxAndroidApplication provides some behavior for initialize the framework in runtime (it isn't only way to configure)
     * MvxAndroidSetup is default setup.
     * App is reference to App class (TipCalc.Core.App)
     */
    public class MainApplication : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}