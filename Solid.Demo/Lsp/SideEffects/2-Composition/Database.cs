using System;

namespace Solid.Demo.Lsp.SideEffects.Composition
{
	public class Database
	{
		public static bool Contains(Guid id)
		{
			return false;
		}
	}
}