using System;

namespace Solid.Demo.Dip.Interface
{
	public class RequestHandler
	{
		private readonly IJsonSerializer _serializer;

		public RequestHandler(IJsonSerializer serializer)
		{
			_serializer = serializer;
		}

		public void OnRequestReceived(string json)
		{
			var data = _serializer.Deserialize<RequestData>(json);

			Console.WriteLine(data.Name + " Received.");
		}
	}
}
