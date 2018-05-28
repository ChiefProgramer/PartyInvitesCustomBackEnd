using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Entities;
using RepositoryMemory;

namespace PartyInvitesCustom.Android {
	[Activity(Label = "RSVP", Theme = "@android:style/Theme.DeviceDefault.Light.DarkActionBar")] 
	public class RsvpActivity : Activity {

		private Button _buttonRSVP;
		private EditText _editName;
		private EditText _editEmail;
		private EditText _editPhone;
		private Switch _switchAttend;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Create your application here
			My.Repository = new PartyInvitesR();
			SetContentView(Resource.Layout.RsvpLayout);

			_buttonRSVP = FindViewById<Button>(Resource.Id.buttonSubmit);
			_editName = FindViewById<EditText>(Resource.Id.textName);
			_editEmail = FindViewById<EditText>(Resource.Id.textEmail);
			_editPhone = FindViewById<EditText>(Resource.Id.textPhone);
			_switchAttend = FindViewById<Switch>(Resource.Id.switchAttend);

			_buttonRSVP.Click += _buttonRSVP_Click;
		}

		private void _buttonRSVP_Click(object sender, EventArgs e) {
			GuestResponse guestResponse = new GuestResponse();
			My.Repository.Add(PopulateGuestResponse(guestResponse));

			Intent intent = new Intent(this, typeof(ThanksActivity));
			intent.PutExtra("GuestResponse", guestResponse.ToJson());
			StartActivity(intent);

			this.Finish();
		}

		private GuestResponse PopulateGuestResponse(GuestResponse aGuestResponse) {
			aGuestResponse.Email = _editEmail.Text;
			aGuestResponse.Name = _editName.Text;
			aGuestResponse.Phone = _editPhone.Text;
			aGuestResponse.WillAttend = _switchAttend.Checked;
			return aGuestResponse;
		}
	}
}