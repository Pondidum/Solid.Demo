namespace Solid.Demo.Isp.SeparateInterfaces
{
	public class Usage
	{
		public void DoSomething<T>(T entity) where T : ISaveable, ILoadable
		{
			entity.Save();
			entity.Load();
		} 
	}
}
