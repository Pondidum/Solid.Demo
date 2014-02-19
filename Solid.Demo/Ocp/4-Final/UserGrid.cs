using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Solid.Demo.Ocp.Final
{
	public class UserGrid
	{
		private readonly List<ToolStripMenuItem> _menu;
		private readonly DataGridView _grid;
		private readonly List<GridHandler> _handlers;

		public UserGrid()
		{
			_handlers = new List<GridHandler>();
			_grid = new DataGridView();
			_menu = new List<ToolStripMenuItem>();
		}

		public void AddHandler(GridHandler handler)
		{
			_handlers.Add(handler);
			_menu.Add(new ToolStripMenuItem { Text = handler.Title });
		}

		public void SetUser(User user)
		{
			_handlers.ForEach(handler => handler.User = user);
		}

		public void Populate()
		{
			var handler = GetHandlerForSelection();

			if (handler != null)
			{
				_grid.Rows.Clear();
				_grid.Rows.AddRange(handler.Populate().ToArray());
			}
		}

		public void OnAddClicked()
		{
			var handler = GetHandlerForSelection();

			if (handler != null)
			{
				handler.Add();
				Populate();
			}
		}

		public void OnEditClicked()
		{
			var row = _grid.SelectedRows[0];
			var handler = GetHandlerForSelection();

			if (handler != null)
			{
				handler.Edit(row.Tag);
				Populate();
			}
		}

		public void OnDeleteClicked()
		{
			var row = _grid.SelectedRows[0];
			var handler = GetHandlerForSelection();

			if (handler != null)
			{
				handler.Delete(row.Tag);
				Populate();
			}
		}

		private GridHandler GetHandlerForSelection()
		{
			var selection = _menu.First(m => m.Checked);

			return _handlers.FirstOrDefault(h => h.Title == selection.Text);
		}
	}
}
