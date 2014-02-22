namespace Solid.Demo.Lsp.Mutation.Original
{
	public class Usage
	{
		public void Run()
		{
			var generator = new DefaultStateGenerator();
			var machine = new StateMachine(generator);

			machine.Transition();
		}
	}
}
