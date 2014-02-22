namespace Solid.Demo.Lsp.Mutation.Original
{
	public interface IStateGenerator
	{
		int GetNextStateID(int currentState);
		int GetStartStateID();
	}
}
