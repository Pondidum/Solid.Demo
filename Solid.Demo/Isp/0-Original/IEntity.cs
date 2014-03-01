using System;

namespace Solid.Demo.Isp.Original
{
	public interface IEntity
	{
		Guid ID { get; }
		void Save();
		void Load();
	}
}
