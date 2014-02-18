namespace Solid.Demo.Srp.FunctionalityExtract
{
	public class Usage
	{

		public void Run()
		{
			var webService = new CachedJobService(new JobWebService());
			var poster = new JobPostingService(webService);

			poster.PostToAllBoards(new Job());
		}
	}
}
