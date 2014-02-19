using System.Windows.Forms;
using Solid.Demo.Ocp.Removal.GridHandlers;

namespace Solid.Demo.Ocp.Removal
{
	public class Usage : Form
	{
		private UserGrid _grid;

		public Usage()
		{
			_grid = new UserGrid();
			_grid.AddHandler(new EmailGridHandler());
		}
	}
}
