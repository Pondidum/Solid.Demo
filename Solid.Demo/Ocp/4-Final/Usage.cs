using System.Windows.Forms;
using Solid.Demo.Ocp.Final.GridHandlers;

namespace Solid.Demo.Ocp.Final
{
	public class Usage : Form
	{
		private UserGrid _grid;

		public Usage()
		{
			_grid = new UserGrid();
			_grid.AddHandler(new EmailGridHandler());
			_grid.AddHandler(new AddressGridHandler());
			_grid.AddHandler(new PhoneGridHandler());
		}
	}
}
