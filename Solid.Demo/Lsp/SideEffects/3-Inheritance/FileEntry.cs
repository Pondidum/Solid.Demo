using System.IO;

namespace Solid.Demo.Lsp.SideEffects.Inheritance
{
	public class FileEntry
	{
		public string Path { get; set; }
		public string Name { get; set; }

		public virtual void Process()
		{
			if (File.Exists(Path) == false)
				throw new FileNotFoundProcessException(Path);

			//do work
			
		}
	}
}