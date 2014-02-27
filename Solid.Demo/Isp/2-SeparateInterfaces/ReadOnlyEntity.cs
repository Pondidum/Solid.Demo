using System;

namespace Solid.Demo.Isp.SeparateInterfaces
{
	public class ReadOnlyEntity : ILoadable
	{
		public Guid ID { get; private set; }

		public void Load()
		{
			using (var reader = Database.Load(ID))
			{
				ID = reader.GetGuid(0);
			}
		}
	}
}
