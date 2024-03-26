using UnityGameLogger.Config.Option;

namespace UnityGameLogger.Config
{
	internal class ConfigLoader
	{
		#region 변수
		public ProjectConfig ProjectConfig;

		public LogConfig LogConfig1;
		public LogConfig LogConfig2;

		public LogConfig[] LogConfigs;

		public GameConfig GameConfig1;
		public GameConfig GameConfig2;
		public GameConfig GameConfig3;

		public GameConfig[] GameConfigs;

		#endregion

		public ConfigLoader()
		{
			ProjectConfig = new ProjectConfig();

			LogConfigs = new LogConfig[]
			{ 
				LogConfig1 = new LogConfig(1),
				LogConfig2 = new LogConfig(2)
			};

			GameConfigs = new GameConfig[]
			{
				GameConfig1 = new GameConfig(1),
				GameConfig2 = new GameConfig(2),
				GameConfig3 = new GameConfig(3)
			};
		}
	}
}
