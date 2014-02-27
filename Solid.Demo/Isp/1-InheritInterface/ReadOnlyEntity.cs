using System;

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
			using (var reader = Database.Load(ID))
			{
				ID = reader.GetGuid(0);
			}
		}

		public void ResetChanges()
		{
			//do nothing
		}

		public bool HasChanged()
		{
			return false;
		}
	}
}
