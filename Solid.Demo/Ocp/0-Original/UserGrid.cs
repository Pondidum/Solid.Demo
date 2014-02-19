using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Solid.Demo.Ocp.Original
{
	public class UserGrid
	{
		private readonly List<ToolStripMenuItem> _menu;
		private readonly DataGridView _grid;
		private User _user;

		public UserGrid()
		{
			_grid = new DataGridView();
			_menu = new List<ToolStripMenuItem>();

			_menu.Add(new ToolStripMenuItem { Text = "Emails", Tag = MenuTypes.Emails });
			_menu.Add(new ToolStripMenuItem { Text = "Addresses", Tag = MenuTypes.Addresses });
			_menu.Add(new ToolStripMenuItem { Text = "Phone Numbers", Tag = MenuTypes.Phones });

		}

		public void SetUser(User user)
		{
			_user = user;
		}

		public void Populate()
		{
			var selection = GetMenuSelection();
			var rows = new List<DataGridViewRow>();

			switch (selection)
			{
				case MenuTypes.Emails:
					rows.AddRange(_user.EmailAddresses);
					break;

				case MenuTypes.Addresses:
					rows.AddRange(_user.Addresses);
					break;

				case MenuTypes.Phones:
					rows.AddRange(_user.PhoneNumbers);
					break;
			}

			_grid.Rows.Clear();
			_grid.Rows.AddRange(rows.ToArray());
		}

		public void OnAddClicked()
		{
			var selection = GetMenuSelection();

			switch (selection)
			{
				case MenuTypes.Emails:

					var emailEditor = new EmailEditor(new Email());
					emailEditor.ShowDialog();

					break;

				case MenuTypes.Addresses:

					var addressEditor = new AddressEditor(new Address());
					addressEditor.ShowDialog();

					break;

				case MenuTypes.Phones:

					var phoneEditor = new PhoneEditor(new Phone());
					phoneEditor.ShowDialog();
					break;
			}
		}
			
		public void OnEditClicked()
		{
			var selection = GetMenuSelection();
			var row = _grid.SelectedRows[0];

			switch (selection)
			{
				case MenuTypes.Emails:

					var emailEditor = new EmailEditor((Email) row.Tag);
					emailEditor.ShowDialog();

					break;

				case MenuTypes.Addresses:
					
					var addressEditor = new AddressEditor((Address) row.Tag);
					addressEditor.ShowDialog();

					break;

				case MenuTypes.Phones:
					
					var phoneEditor = new PhoneEditor((Phone) row.Tag);
					phoneEditor.ShowDialog();
					break;
			}
		}



		private MenuTypes GetMenuSelection()
		{
			return (MenuTypes)_menu.First(m => m.Checked).Tag;
		}

		private enum MenuTypes
		{
			Emails,
			Addresses,
			Phones,
		}
	}
}
