namespace Solid.Demo.Lsp.Mutation.Original
{
	public class StateMachine
	{
		private int _currentState;
		private readonly IStateGenerator _generator;

		public StateMachine(IStateGenerator generator)
		{
			_generator = generator;
			_currentState = generator.GetStartStateID();
		}

		public void Transition()
		{
			var newState = _generator.GetNextStateID(_currentState);

			switch (newState)
			{
				case 0:
					//do nothing
					break;

				case 1:
					//do nothing
					break;

				case 2:
					PayTheMan();
					break;
			}

			_currentState = newState;
		}

		private void PayTheMan()
		{
			//spend lots of money
		}
	}
}
