using System;

namespace Solid.Demo.Lsp.Inheritance
{
	public class KeyNotFoundProcessException : ProcessException
	{
		public KeyNotFoundProcessException(Guid id)
		{}
	}
}