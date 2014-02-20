using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Solid.Demo.Ocp.Final.GridHandlers
{
	public class AddressGridHandler : GridHandler
	{
		public override string Title
		{
			get { return "Addresses"; }
		}

		public override IEnumerable<DataGridViewRow> Populate()
		{
			//return User.Addresses;
			return Enumerable.Empty<DataGridViewRow>();
		}

		public override void Add()
		{
			var address = new Address();
			var editor = new AddressEditor(address);

			editor.ShowDialog();

			User.AddAddress(address);
		}

		public override void Edit(object item)
		{
			var address = (Address)item;
			var editor = new AddressEditor(address);

			editor.ShowDialog();
		}

		public override void Delete(object item)
		{
			var address = (Address)item;
			User.RemoveAddress(address);
		}
	}
}

