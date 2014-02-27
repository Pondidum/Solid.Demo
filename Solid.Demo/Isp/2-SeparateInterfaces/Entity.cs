﻿using System;

namespace Solid.Demo.Isp.SeparateInterfaces
{
	public class Entity : ISaveable, ILoadable
	{
		public Guid ID { get; private set; }

		public void Save()
		{
			Database.Save(this);
		}

		public void Load()
		{
			using (var reader = Database.Load(ID))
			{
				ID = reader.GetGuid(0);
			}
		}

		public void ResetChanges()
		{
			ID = Guid.Empty;
		}

		public bool HasChanged()
		{
			return ID != Guid.Empty;
		}
	}
}
