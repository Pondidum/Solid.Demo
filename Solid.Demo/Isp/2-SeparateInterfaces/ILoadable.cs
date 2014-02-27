using System;

namespace Solid.Demo.Isp.SeparateInterfaces
{
	public interface ILoadable
	{
		Guid ID { get; }
		void Load();
	}
}
