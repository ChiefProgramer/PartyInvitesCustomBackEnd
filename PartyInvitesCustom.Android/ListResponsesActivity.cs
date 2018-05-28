using Android.App;
using Android.OS;
using Android.Widget;

namespace PartyInvitesCustom.Android {
	[Activity(Label = "List of Guests", Theme = "@android:style/Theme.DeviceDefault.Light.DarkActionBar")]
	public class ListResponsesActivity : Activity {
		private ListView _guestList;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.ListResponsesLayout);

			_guestList = FindViewById<ListView>(Resource.Id.lvResponse);

			_guestList.Adapter = new GuestListAdapter(this);


		}
	}
}