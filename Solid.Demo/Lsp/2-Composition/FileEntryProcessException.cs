using System;

namespace Solid.Demo.Lsp.Composition
{
	public class FileEntryProcessException : Exception
	{
		public FileEntryProcessException(Exception inner) : base("", inner)
		{
		}
	}
}
