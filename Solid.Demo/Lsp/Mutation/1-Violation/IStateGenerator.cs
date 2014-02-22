namespace Solid.Demo.Lsp.Mutation.Violation
{
	public interface IStateGenerator
	{
		int GetNextStateID(int currentState);
		int GetStartStateID();
	}
}
