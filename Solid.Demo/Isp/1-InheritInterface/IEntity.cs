using System;

namespace Solid.Demo.Isp.InheritInterface
{
	public interface IEntity
	{
		Guid ID { get; }
		void Save();
		void Load();
		void ResetChanges();
		bool HasChanged();
	}
}
