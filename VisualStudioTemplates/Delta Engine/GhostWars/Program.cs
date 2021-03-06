using DeltaEngine.Core;
using DeltaEngine.Platforms;

namespace $safeprojectname$
{
	internal class Program : App
	{
		public Program()
		{
			var window = Resolve<Window>();
			new MainMenu(window);
		}

		static void Main()
		{
			new Program().Run();
		}
	}
}