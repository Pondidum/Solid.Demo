using System.Collections.Generic;
using System.Linq;

namespace Solid.Demo.Srp.FunctionalityExtract
{
	public class JobPostingService
	{
		private readonly IJobService _jobService;

		public JobPostingService(IJobService jobService)
		{
			_jobService = jobService;
		}

		public IEnumerable<Job> GetCurrentJobs()
		{
			return _jobService.GetLiveJobs();
		}

		public void PostToFreeBoards(Job job)
		{
			var jobs = GetCurrentJobs();

			if (jobs.Any(j => j.ID == job.ID))
				return;

			_jobService.Post(job, Boards.FreeBoard1 | Boards.FreeBoard2);
		}

		public void PostToAllBoards(Job job)
		{
			var jobs = GetCurrentJobs();

			if (jobs.Any(j => j.ID == job.ID))
				return;

			_jobService.Post(job, Boards.PaidBoard1 | Boards.PaidBoard2);
		}
	}
}
