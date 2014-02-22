using System;

namespace Solid.Demo.Lsp.SideEffects.Composition
{
	public class FileEntryProcessException : Exception
	{
		public FileEntryProcessException(Exception inner) : base("", inner)
		{
		}
	}
}
