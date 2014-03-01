using System;

namespace Solid.Demo.Isp.SeparateInterfaces
{
	public interface ISaveable
	{
		Guid ID { get; }
		void Save();
	}
}
