﻿using System.IO;

namespace Solid.Demo.Lsp.SideEffects.Composition
{
	public class FileEntry
	{
		public string Path { get; set; }
		public string Name { get; set; }

		public virtual void Process()
		{
			if (File.Exists(Path) == false)
				throw new FileEntryProcessException(new FileNotFoundException(Path));

			//do work

		}
	}
}