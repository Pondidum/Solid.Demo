using System;
using System.Collections.Generic;

namespace Solid.Demo.Lsp.SideEffects.Composition
{
	public class DbFileEntry : FileEntry
	{
		private readonly Guid _id;

		public DbFileEntry()
		{
			_id = Guid.NewGuid();
		}

		public override void Process()
		{
			if (Database.Contains(_id) == false)
				throw new FileEntryProcessException(new KeyNotFoundException(_id.ToString()));

			//do work
		}
	}
}
