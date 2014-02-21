using System;

namespace Solid.Demo.Lsp.Violating
{
	public class Database
	{
		public static bool Contains(Guid id)
		{
			return false;
		}
	}
}