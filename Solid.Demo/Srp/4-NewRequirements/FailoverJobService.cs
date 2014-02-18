using System.Collections.Generic;
using System.Linq;

namespace Solid.Demo.Srp.NewRequirements
{
	public class FailoverJobService : IJobService
	{
		private readonly List<IJobService> _services;

		public FailoverJobService(params IJobService[] services)
		{
			_services = services.ToList();
		}

		public IEnumerable<Job> GetLiveJobs()
		{
			return _services.SelectMany(s => s.GetLiveJobs());
		}

		public bool Post(Job job, Boards boards)
		{
			return _services.Any(service => service.Post(job, boards));
		}
	}
}
