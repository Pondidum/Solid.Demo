using System;
using System.Data;

namespace Solid.Demo.Isp.InheritInterface
{
	public class Database
	{
		public static void Save(IEntity entity)
		{

		}

		public static IDataReader Load(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}