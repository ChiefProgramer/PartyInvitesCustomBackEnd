using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Contracts;
using RepositoryMemory;

namespace PartyInvitesCustom.Android {
	public static class My {
		public static  IPartyInvitesR Repository = new PartyInvitesR();


	}
}