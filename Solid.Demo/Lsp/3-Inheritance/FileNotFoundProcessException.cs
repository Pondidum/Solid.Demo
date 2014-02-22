using System;

namespace Solid.Demo.Lsp.Inheritance
{
	public class FileNotFoundProcessException : ProcessException
	{
		public FileNotFoundProcessException(String path)
		{}
	}
}