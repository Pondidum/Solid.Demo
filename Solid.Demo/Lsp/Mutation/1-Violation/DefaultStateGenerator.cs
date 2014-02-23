using System;

namespace Solid.Demo.Lsp.Mutation.Violation
{
	public class DefaultStateGenerator : IStateGenerator
	{
		public int GetNextStateID(int currentState)
		{
			return Math.Min(++currentState, 3);
		}

		public int GetStartStateID()
		{
			return 0;
		}
	}
}
