namespace Solid.Demo.Lsp.Violating
{
	public class Usage
	{
		public void Run()
		{
			ProcessFile(new FileEntry());

			//or
			ProcessFile(new DbFileEntry());
		}

		private void ProcessFile(FileEntry file)
		{
			
		}
	}
}
