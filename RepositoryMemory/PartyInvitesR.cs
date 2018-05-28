namespace RepositoryMemory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Contracts;
	using Entities;

	public class PartyInvitesR: IPartyInvitesR
	{
		private static readonly List<GuestResponse> _Storage =
			new List<GuestResponse>();

		public int Count()
		{
			int vResult = _Storage.Count;
			return vResult;
		}

		public bool Exists(Guid aGuestResponseId)
		{
			GuestResponse vGuest =
				_Storage.FirstOrDefault(_ => _.Id.Equals(aGuestResponseId));
			return (vGuest != null);
		}

		public void Add(GuestResponse aGuestResponse)
		{
			_Storage.Add(aGuestResponse);
		}

		public void Update(GuestResponse aGuestResponse)
		{
			GuestResponse vGuest =
				_Storage.FirstOrDefault(_ => _.Id.Equals(aGuestResponse.Id));
			vGuest?.AssignFrom(aGuestResponse);
		}

		public void Delete(Guid aGuestResponseId)
		{
			GuestResponse vGuest =
				_Storage.FirstOrDefault(_ => _.Id.Equals(aGuestResponseId));
			if (vGuest != null)
			{
				_Storage.Remove(vGuest);
			}
		}

		public void DeleteAll()
		{
			_Storage.Clear();
		}

		public GuestResponse Get(Guid aGuestResponseId)
		{
			GuestResponse vResult =
				_Storage.FirstOrDefault(_ => _.Id.Equals(aGuestResponseId));
			return vResult;
		}

		public List<GuestResponse> GetAll()
		{
			List<GuestResponse> vResult = new List<GuestResponse>();
			foreach (GuestResponse vRec in _Storage)
			{
				GuestResponse vNewRec = new GuestResponse();
				vNewRec.AssignFrom(vRec);
				vResult.Add(vNewRec);
			}
			return vResult;
		}

	}
}