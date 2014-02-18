namespace Solid.Demo.Srp.Injection
{
	public class Usage
	{

		public void Run()
		{
			var poster = new JobPostingService(new JobWebService());

			poster.PostToAllBoards(new Job());
		}
	}
}
