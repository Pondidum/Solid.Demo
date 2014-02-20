using System.Collections.Generic;

namespace Solid.Demo.Ocp
{
	public class User
	{
		private readonly List<Email> _emailAddresses;
		private readonly List<Phone> _phoneNumbers;
		private readonly List<Address> _addresses;

		public User()
		{
			_emailAddresses = new List<Email>();
			_phoneNumbers = new List<Phone>();
			_addresses = new List<Address>();
		}

		public IEnumerable<Email> EmailAddresses { get { return _emailAddresses; } }
		public IEnumerable<Phone> PhoneNumbers { get { return _phoneNumbers; } }
		public IEnumerable<Address> Addresses { get { return _addresses; } }

		public void AddEmail(Email email)
		{
			_emailAddresses.Add(email);
		}

		public void RemoveEmail(Email email)
		{
			_emailAddresses.Remove(email);
		}

		public void AddAddress(Address address)
		{
			_addresses.Remove(address);
		}

		public void RemoveAddress(Address address)
		{
			_addresses.Add(address);
		}
		
		public void AddPhone(Phone phone)
		{
			_phoneNumbers.Add(phone);
		}

		public void RemovePhone(Phone phone)
		{
			_phoneNumbers.Remove(phone);
		}
	}
}
