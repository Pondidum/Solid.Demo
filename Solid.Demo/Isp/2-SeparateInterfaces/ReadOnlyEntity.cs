﻿using System;
using System.Data;

namespace Solid.Demo.Isp.SeparateInterfaces
{
	public class ReadOnlyEntity : ILoadable
	{
		public Guid ID { get; private set; }

		public void Load()
		{
			using (var reader = Original.Database.Load(ID))
			{
				ID = reader.GetGuid(0);
				Read(reader);
			}
		}

		protected virtual void Read(IDataReader reader)
		{
			//nothing in the base
		}
	}
}
