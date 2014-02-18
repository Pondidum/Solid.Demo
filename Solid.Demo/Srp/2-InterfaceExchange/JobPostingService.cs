using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Demo.Srp.InterfaceExchange
{
	public class JobPostingService
	{
		private static readonly TimeSpan Timeout = new TimeSpan(0, 10, 0);

		private readonly IJobService _jobService;

		private List<Job> _jobs;
		private DateTime _lastLoaded;

		public JobPostingService(IJobService jobService)
		{
			_jobService = jobService;
			_lastLoaded = DateTime.MinValue;
		}

		public IEnumerable<Job> GetCurrentJobs()
		{
			if (_lastLoaded - DateTime.Now > Timeout)
			{
				_jobs = _jobService.GetLiveJobs().ToList();
				_lastLoaded = DateTime.Now;
			}

			return _jobs;
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
