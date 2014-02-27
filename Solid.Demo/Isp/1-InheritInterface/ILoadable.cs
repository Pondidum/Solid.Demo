using System;

namespace Solid.Demo.Isp.InheritInterface
{
	public interface ILoadable
	{
		Guid ID { get; }
		void Load();
	}
}
