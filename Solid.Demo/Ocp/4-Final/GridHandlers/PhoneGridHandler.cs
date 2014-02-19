using System.Collections.Generic;
using System.Windows.Forms;

namespace Solid.Demo.Ocp.Final.GridHandlers
{
	public class PhoneGridHandler : GridHandler
	{
		public override string Title
		{
			get { return "Phone Numbers"; }
		}

		public override IEnumerable<DataGridViewRow> Populate()
		{
			return User.PhoneNumbers;
		}

		public override void Add()
		{
			var phone = new Phone();
			var editor = new PhoneEditor(phone);

			editor.ShowDialog();

			User.AddPhone(phone);
		}

		public override void Edit(object item)
		{
			var phone = (Phone)item;
			var editor = new PhoneEditor(phone);

			editor.ShowDialog();
		}

		public override void Delete(object item)
		{
			var phone = (Phone)item;
			User.RemovePhone(phone);
		}
	}
}

