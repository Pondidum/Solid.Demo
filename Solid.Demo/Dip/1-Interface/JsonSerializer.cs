namespace Solid.Demo.Dip.Interface
{
	public class JsonSerializer : IJsonSerializer
	{
		public T Deserialize<T>(string json)
		{
			return NewtonSoftJson.Deserialize<T>(json);
		}
	}
}