using Android.App;
using MvvmCross.Droid.Views;

namespace WearTest.Wear.Activities
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, NoHistory = true)]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreenView)
        {

        }
    }
}