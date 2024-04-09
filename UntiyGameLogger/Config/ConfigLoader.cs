using System;
using UnityGameLogger.Config.Option;

namespace UnityGameLogger.Config
{
	internal class ConfigLoader
	{
		private static readonly Lazy<ConfigLoader> instance = new Lazy<ConfigLoader>(() => new ConfigLoader());

		#region 변수
		public ProjectConfig ProjectConfig;

		public LogConfig LogConfig;

		public GameConfig GameConfig1;
		public GameConfig GameConfig2;
		public GameConfig GameConfig3;

		public GameConfig[] GameConfigs;
		#endregion

		private ConfigLoader()
		{
			ProjectConfig = new ProjectConfig();

			LogConfig = new LogConfig();

			GameConfigs = new GameConfig[]
			{
				GameConfig1 = new GameConfig(0),
				GameConfig2 = new GameConfig(1),
				GameConfig3 = new GameConfig(2)
			};
		}

		public static ConfigLoader Instance
		{
			get => instance.Value;
		}
	}
}
