using System;

namespace Solid.Demo.Lsp.SideEffects.Inheritance
{
	public class Database
	{
		public static bool Contains(Guid id)
		{
			return false;
		}
	}
}