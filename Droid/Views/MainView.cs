using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Ossus.Droid.Views
{
    [Activity(Label = "Star Wars Characters")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
