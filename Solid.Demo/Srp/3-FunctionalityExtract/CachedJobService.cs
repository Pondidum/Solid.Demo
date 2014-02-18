using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Demo.Srp.FunctionalityExtract
{
	public class CachedJobService : IJobService
	{
		private List<Job> _jobs;
		private DateTime _lastLoaded;
		private readonly TimeSpan _timeout;
		private readonly IJobService _other;

		public CachedJobService(IJobService otherService)
			: this(otherService, new TimeSpan(0, 10, 0))
		{
		}

		public CachedJobService(IJobService otherService, TimeSpan timeout)
		{
			_other = otherService;
			_timeout = timeout;
			_lastLoaded = DateTime.MinValue;
		}

		public IEnumerable<Job> GetLiveJobs()
		{
			if (_lastLoaded - DateTime.Now > _timeout)
			{
				_jobs = _other.GetLiveJobs().ToList();
				_lastLoaded = DateTime.Now;
			}

			return _jobs;
		}

		public bool Post(Job job, Boards boards)
		{
			return _other.Post(job, boards);
		}
	}
}
