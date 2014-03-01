using System;

namespace Solid.Demo.Isp.InheritInterface
{
	public interface ISaveable
	{
		Guid ID { get; }
		void Save();
	}
}
