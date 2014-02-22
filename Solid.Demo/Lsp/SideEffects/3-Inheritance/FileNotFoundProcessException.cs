using System;

namespace Solid.Demo.Lsp.SideEffects.Inheritance
{
	public class FileNotFoundProcessException : ProcessException
	{
		public FileNotFoundProcessException(String path)
		{}
	}
}