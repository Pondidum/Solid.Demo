using System.Collections.Generic;
using System.Windows.Forms;

namespace Solid.Demo.Ocp
{
	public class User
	{
		public IEnumerable<DataGridViewRow> EmailAddresses { get; private set; }
		public IEnumerable<DataGridViewRow> PhoneNumbers { get; private set; }
		public IEnumerable<DataGridViewRow> Addresses { get; private set; }

		public void AddEmail(Email email)
		{
		}

		public void RemoveEmail(Email email)
		{
		}

		public void RemoveAddress(Address email)
		{
		}

		public void AddAddress(Address email)
		{
		}
	}
}
