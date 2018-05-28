namespace Entities {
	using System;


	public class GuestResponse {
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool? WillAttend { get; set; }

	}

	public static class GuestResponseHelper {
		private static void FromTo(GuestResponse aFrom, GuestResponse aTo) {
			aTo.Id = aFrom.Id;
			aTo.Name = aFrom.Name;
			aTo.Email = aFrom.Email;
			aTo.Phone = aFrom.Phone;
			aTo.WillAttend = aFrom.WillAttend;
		}

		public static void AssignTo(this GuestResponse aFrom, GuestResponse aTo) {
			FromTo(aFrom, aTo);
		}

		public static void AssignFrom(this GuestResponse aTo, GuestResponse aFrom) {
			FromTo(aFrom, aTo);
		}

		public static string ToJson(this GuestResponse aFrom) {
			return Newtonsoft.Json.JsonConvert.SerializeObject(aFrom);
		}

		public static GuestResponse FromJson(this GuestResponse aTo, string aFrom) {
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GuestResponse>(aFrom);
		}





	}
}