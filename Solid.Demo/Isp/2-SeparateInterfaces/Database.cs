using System;
using System.Data;

namespace Solid.Demo.Isp.SeparateInterfaces
{
	public class Database
	{
		public static void Save(ISaveable entity)
		{

		}

		public static IDataReader Load(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}