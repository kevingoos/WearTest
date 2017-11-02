using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using WearTest.Core.ViewModels;

namespace WearTest.Wear.Activities
{
    [Activity(Label = "AMDM.Wear")]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);

            //var v = FindViewById<WatchViewStub>(Resource.Id.watch_view_stub);
            //v.LayoutInflated += delegate
            //{

            //    // Get our button from the layout resource,
            //    // and attach an event to it
            //    Button button = FindViewById<Button>(Resource.Id.myButton);

            //    button.Click += delegate
            //    {
            //        var notification = new NotificationCompat.Builder(this)
            //            .SetContentTitle("Button tapped")
            //            .SetContentText("Button tapped " + count++ + " times!")
            //            .SetSmallIcon(Android.Resource.Drawable.StatNotifyVoicemail)
            //            .SetGroup("group_key_demo").Build();

            //        var manager = NotificationManagerCompat.From(this);
            //        manager.Notify(1, notification);
            //        button.Text = "Check Notification!";
            //    };
            //};
        }
    }
}


