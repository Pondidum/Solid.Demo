using System;
using System.Collections.Generic;
using System.IO;

namespace Solid.Demo.Lsp.SideEffects.Composition
{
	public class Usage
	{
		private List<String> _fails;

		public Usage()
		{
			_fails = new List<string>();
		}

		public void Run1()
		{
			var files = new[]
			{
				new FileEntry(),
				new FileEntry(),
				new FileEntry(),
			};

			RunFiles(files);
		}

		public void Run2()
		{
			var files = new[]
			{
				new DbFileEntry(), 
				new DbFileEntry(),
				new DbFileEntry(),
			};

			RunFiles(files);
		}

		public void RunFiles(IEnumerable<FileEntry> files)
		{
			foreach (var file in files)
			{
				try
				{
					file.Process();
				}
				catch (FileEntryProcessException ex)
				{
					_fails.Add(file.Name);
				}
			}
		}
	}
}
