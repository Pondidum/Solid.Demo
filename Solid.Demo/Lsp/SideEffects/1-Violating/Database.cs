using System;

namespace Solid.Demo.Lsp.SideEffects.Violating
{
	public class Database
	{
		public static bool Contains(Guid id)
		{
			return false;
		}
	}
}