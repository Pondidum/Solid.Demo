﻿using System;

namespace Solid.Demo.Lsp.Mutation.Violation
{
	public class EvilStateGenerator : IStateGenerator
	{
		private bool _evil;

		public int GetNextStateID(int currentState)
		{
			return _evil ? 2 : Math.Min(++currentState, 3);
		}

		public int GetStartStateID()
		{
			return 0;
		}

		public void BeEvil()
		{
			_evil = true;
		}
	}
}
