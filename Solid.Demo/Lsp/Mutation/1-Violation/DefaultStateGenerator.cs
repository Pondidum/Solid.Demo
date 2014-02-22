namespace Solid.Demo.Lsp.Mutation.Violation
{
	public class DefaultStateGenerator : IStateGenerator
	{
		public int GetNextStateID(int currentState)
		{
			return ++currentState;
		}

		public int GetStartStateID()
		{
			return 0;
		}
	}
}
