namespace Solid.Demo.Lsp.Mutation.Violation
{
	public class Usage
	{
		public void Run()
		{
			var generator = new EvilStateGenerator();
			var machine = new StateMachine(generator);

			//as normal
			machine.Transition();

			//oh whats this?
			generator.BeEvil();

			//now we pay the man on every call transtion...
			machine.Transition();
			machine.Transition();
			machine.Transition();
		}
	}
}
