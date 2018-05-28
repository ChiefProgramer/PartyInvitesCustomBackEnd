using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Widget;
using Entities;

namespace PartyInvitesCustom.Android {
	class GuestListAdapter : BaseAdapter<GuestResponse> {
		private IList<GuestResponse> _GuestList;
		private Activity _Context;

		public GuestListAdapter(Activity Context) {
			_Context = Context;
		   _GuestList = My.Repository.GetAll().Where(r => r.WillAttend == true).ToList();
		}

		public override GuestResponse this[int position] => _GuestList[position];

		public override int Count => _GuestList.Count;

		public override long GetItemId(int position) {
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent) {
			View view = convertView;

			if (view == null) {
				view = _Context.LayoutInflater.Inflate(Resource.Layout.GuestResponseLayout, null);
				SetReferancesToUIelements(view);
			}

			lvGuestRViewHolder Holder = (lvGuestRViewHolder)view.Tag;	

			GuestResponse guest = (GuestResponse)_GuestList[position];
			Holder.Name.Text = _GuestList[position].Name;
			Holder.Email.Text = _GuestList[position].Email;
			Holder.Phone.Text = _GuestList[position].Phone;

			return view;
		}

		public void SetReferancesToUIelements(View view) {
			TextView vName = view.FindViewById<TextView>(Resource.Id.textViewName);
			TextView vEmail = view.FindViewById<TextView>(Resource.Id.textViewEmail);
			TextView vPhone = view.FindViewById<TextView>(Resource.Id.textViewPhone);

			view.Tag = new lvGuestRViewHolder() { Name = vName, Email = vEmail, Phone = vPhone };
		}

		public class lvGuestRViewHolder : Java.Lang.Object {
			public TextView Name { get; set; }
			public TextView Email { get; set; }
			public TextView Phone { get; set; } 
		}
	}
}