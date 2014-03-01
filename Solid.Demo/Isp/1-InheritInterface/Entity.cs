using System;
using System.Data;

namespace Solid.Demo.Isp.InheritInterface
{
	public class Entity : IEntity
	{
		public Guid ID { get; private set; }

		public void Save()
		{
			Database.Save(this);
		}

		public void Load()
		{
			using (var reader = Database.Load(ID))
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
