using System.Collections.Generic;
using System.Linq;

namespace Solid.Demo.Srp.Injection
{
	public class JobWebService
	{
		public IEnumerable<Job> GetLiveJobs()
		{
			return Enumerable.Empty<Job>();
		}

		public bool Post(Job job, Boards boards)
		{
			return true;
		}
	}
}
