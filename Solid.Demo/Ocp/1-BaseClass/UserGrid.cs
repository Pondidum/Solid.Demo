using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Solid.Demo.Ocp.BaseClass
{
	public class UserGrid
	{
		private readonly List<ToolStripMenuItem> _menu;
		private readonly DataGridView _grid;
		private readonly List<GridHandler> _handlers;
		private User _user;

		public UserGrid()
		{
			_handlers = new List<GridHandler>();
			_grid = new DataGridView();
			_menu = new List<ToolStripMenuItem>();

			_menu.Add(new ToolStripMenuItem { Text = "Emails", Tag = MenuTypes.Emails });
			_menu.Add(new ToolStripMenuItem { Text = "Addresses", Tag = MenuTypes.Addresses });
			_menu.Add(new ToolStripMenuItem { Text = "Phone Numbers", Tag = MenuTypes.Phones });

		}

		public void AddHandler(GridHandler handler)
		{
			_handlers.Add(handler);

			_menu.Add(new ToolStripMenuItem { Text = handler.Title });
		}

		public void SetUser(User user)
		{
			_user = user;
		}

		public void Populate()
		{
			var handler = GetHandlerForSelection();

			if (handler != null)
			{
				_grid.Rows.Clear();
				_grid.Rows.AddRange(handler.Populate().ToArray());
				return;
			}

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
			var handler = GetHandlerForSelection();

			if (handler != null)
			{
				handler.Add();
				return;
			}

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
			var row = _grid.SelectedRows[0];
			var handler = GetHandlerForSelection();

			if (handler != null)
			{
				handler.Edit(row.Tag);
				return;
			}

			var selection = GetMenuSelection();

			switch (selection)
			{
				case MenuTypes.Emails:

					var emailEditor = new EmailEditor((Email)row.Tag);
					emailEditor.ShowDialog();

					break;

				case MenuTypes.Addresses:

					var addressEditor = new AddressEditor((Address)row.Tag);
					addressEditor.ShowDialog();

					break;

				case MenuTypes.Phones:

					var phoneEditor = new PhoneEditor((Phone)row.Tag);
					phoneEditor.ShowDialog();
					break;
			}
		}



		private MenuTypes GetMenuSelection()
		{
			return (MenuTypes)_menu.First(m => m.Checked).Tag;
		}

		private GridHandler GetHandlerForSelection()
		{
			var selection = _menu.First(m => m.Checked);

			return _handlers.FirstOrDefault(h => h.Title == selection.Text);
		}

		private enum MenuTypes
		{
			Emails,
			Addresses,
			Phones,
		}
	}
}
