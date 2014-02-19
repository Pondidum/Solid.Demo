using System.Windows.Forms;
using Solid.Demo.Ocp.Implementing.GridHandlers;

namespace Solid.Demo.Ocp.Implementing
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
