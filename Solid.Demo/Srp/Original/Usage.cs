namespace Solid.Demo.Srp.Original
{
	public class Usage
	{

		public void Run()
		{
			var poster = new JobPostingService();

			poster.PostToAllBoards(new Job());
		}
	}
}
