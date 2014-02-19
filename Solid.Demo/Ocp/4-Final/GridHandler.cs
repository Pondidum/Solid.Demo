using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Solid.Demo.Ocp.Final
{
	public abstract class GridHandler
	{
		public User User { get; set; }
		public abstract String Title { get; }
		public abstract IEnumerable<DataGridViewRow> Populate();

		public virtual void Add()
		{
		}

		public virtual void Edit(object item)
		{
		}

		public virtual void Delete(object item)
		{
		}
	}
}
