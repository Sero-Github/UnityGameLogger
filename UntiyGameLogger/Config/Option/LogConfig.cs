namespace UnityGameLogger.Config.Option
{
	internal class LogConfig : BaseConfig
	{
		private string _logDirectory;

		public LogConfig(int ConfigSlot) : base(ConfigSlot, "LOG") { }

		public string LogDirectory
		{ 
			get { return _logDirectory; }
			set
			{
				_logDirectory = value;
				EditConfig($"LOG_PATH{_configSlot}", value);
				Program.LogFileWatchers[_configSlot - 1].Path = value;
			}
		}

		protected override void InitConfig()
		{
			InitOption($"LOG_PATH{_configSlot}", ref _logDirectory);
		}
	}
}
