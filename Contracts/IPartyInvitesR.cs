namespace Contracts
{
	using System;
	using System.Collections.Generic;
	using Entities;

	public interface IPartyInvitesR
	{
		int Count();
		void Add(GuestResponse aGuestResponse);
		void Update(GuestResponse aGuestResponse);
		void Delete(Guid aGuesResponseId);
		GuestResponse Get(Guid aGuestResponseId);
		List<GuestResponse> GetAll();
		// Discovered the need for the following during testing
		void DeleteAll();
		bool Exists(Guid aId);

	}
}