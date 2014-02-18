using System.Collections.Generic;

namespace Solid.Demo.Srp.NewRequirements
{
	public interface IJobService
	{
		IEnumerable<Job> GetLiveJobs();
		bool Post(Job job, Boards boards);
	}
}
