using System;
using System.Data;

namespace Solid.Demo.Isp.InheritInterface
{
	public class ReadOnlyEntity : IEntity
	{
		public Guid ID { get; private set; }

		public void Save()
		{
			//do nothing
		}

		public void Load()
		{
			using (var reader = Original.Database.Load(ID))
			{
				ID = reader.GetGuid(0);
				Read(reader);
			}
		}

		protected virtual void Read(IDataReader reader)
		{
			//nothing in the base
		}
	}
}
