using UnityGameLogger.Config.Option;

namespace UnityGameLogger.Config
{
	internal class ConfigLoader
	{
		#region 변수
		public ProjectConfig ProjectConfig;

		public LogConfig LogConfig;

		public GameConfig GameConfig1;
		public GameConfig GameConfig2;
		public GameConfig GameConfig3;

		public GameConfig[] GameConfigs;

		#endregion

		public ConfigLoader()
		{
			ProjectConfig = new ProjectConfig();

			LogConfig = new LogConfig();

			GameConfigs = new GameConfig[]
			{
				GameConfig1 = new GameConfig(1),
				GameConfig2 = new GameConfig(2),
				GameConfig3 = new GameConfig(3)
			};
		}
	}
}
