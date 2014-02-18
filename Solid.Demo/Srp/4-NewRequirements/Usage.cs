namespace Solid.Demo.Srp.NewRequirements
{
	public class Usage
	{

		public void RunUsage1()
		{
			var primaryService = new CachedJobService(new JobWebService());
			var secondaryService = new CachedJobService(new BackupWebService());

			var failover = new FailoverJobService(primaryService, secondaryService);

			var poster = new JobPostingService(failover);

			poster.PostToAllBoards(new Job());
		}

		public void RunUsage2()
		{
			var primaryService = new JobWebService();
			var secondaryService = new BackupWebService();

			var failover = new CachedJobService(new FailoverJobService(primaryService, secondaryService));

			var poster = new JobPostingService(failover);

			poster.PostToAllBoards(new Job());
		}
	}
}
