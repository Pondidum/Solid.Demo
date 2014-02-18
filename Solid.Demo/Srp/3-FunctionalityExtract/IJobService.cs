using System.Collections.Generic;

namespace Solid.Demo.Srp.FunctionalityExtract
{
	public interface IJobService
	{
		IEnumerable<Job> GetLiveJobs();
		bool Post(Job job, Boards boards);
	}
}
