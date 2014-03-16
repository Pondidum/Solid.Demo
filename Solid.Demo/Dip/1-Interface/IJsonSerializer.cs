namespace Solid.Demo.Dip.Interface
{
	public interface IJsonSerializer
	{
		T Deserialize<T>(string json);
	}
}
