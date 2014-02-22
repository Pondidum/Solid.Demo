using System;

namespace Solid.Demo.Lsp.SideEffects.Inheritance
{
	public class KeyNotFoundProcessException : ProcessException
	{
		public KeyNotFoundProcessException(Guid id)
		{}
	}
}