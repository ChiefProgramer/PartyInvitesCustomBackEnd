using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Entities;

namespace PartyInvitesCustom.Android {
	[Activity(Label = "Thanks", Theme = "@android:style/Theme.DeviceDefault.Light.DarkActionBar")]
	public class ThanksActivity : Activity {
		private Button _buttonRSVP;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.ThanksActivity);

			GuestResponse vGuestResponse = new GuestResponse().FromJson(Intent.GetStringExtra("GuestResponse"));

			_buttonRSVP = FindViewById<Button>(Resource.Id.buttonThanks);

			var vtextThanks = FindViewById<TextView>(Resource.Id.textThanks);
			vtextThanks.Text = "Thank you, " + vGuestResponse.Name + " for RSVPing!";

			_buttonRSVP.Click += _buttonRSVP_Click;

		}

		private void _buttonRSVP_Click(object sender, EventArgs e) {
			Intent intent = new Intent(this, typeof(ListResponsesActivity));
			StartActivity(intent);

			this.Finish();
		}
	}
}