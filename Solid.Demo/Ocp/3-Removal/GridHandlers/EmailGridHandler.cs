using System.Collections.Generic;
using System.Windows.Forms;

namespace Solid.Demo.Ocp.Removal.GridHandlers
{
	public class EmailGridHandler : GridHandler
	{
		public override string Title
		{
			get { return "Email Addresses"; }
		}

		public override IEnumerable<DataGridViewRow> Populate()
		{
			return User.EmailAddresses;
		}

		public override void Add()
		{
			var email = new Email();
			var editor = new EmailEditor(email);

			editor.ShowDialog();

			User.AddEmail(email);
		}

		public override void Edit(object item)
		{
			var email = (Email)item;
			var editor = new EmailEditor(email);

			editor.ShowDialog();
		}

		public override void Delete(object item)
		{
			var email = (Email)item;
			User.RemoveEmail(email);
		}
	}
}

