using System;

namespace Solid.Demo.Dip.Original
{
	public class RequestHandler
	{
		public void OnRequestReceived(string json)
		{
			var data = NewtonSoftJson.Deserialize<RequestData>(json);

			Console.WriteLine(data.Name + " Received.");
		}
	}
}
