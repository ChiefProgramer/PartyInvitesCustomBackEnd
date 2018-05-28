using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace PartyInvitesCustom.Android {
	[Activity(Label = "PartyInvitesCustom", MainLauncher = true, Theme = "@android:style/Theme.DeviceDefault.Light.DarkActionBar")]
	public class MainActivity : Activity {
		private Button _buttonRSVP;
		  

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			_buttonRSVP = FindViewById<Button>(Resource.Id.buttonRSVP);
			_buttonRSVP.Click += _buttonRSVP_Click;

		}

		private void _buttonRSVP_Click(object sender, System.EventArgs e) {
			Intent intent = new Intent(this, typeof(RsvpActivity));
			StartActivity(intent);
		}
	}
}

