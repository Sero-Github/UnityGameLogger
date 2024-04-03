namespace UnityGameLogger.Config.Option
{
	internal class LogConfig : BaseConfig
	{
		private string _logDirectory;

		public LogConfig() : base(0, "LOG") { }

		public string LogDirectory
		{ 
			get { return _logDirectory; }
			set
			{
				_logDirectory = value;
				EditConfig("LOG_PATH", value);
				Program.LogFileWatcher.Path = value;
			}
		}

		protected override void InitConfig()
		{
			InitOption("LOG_PATH", ref _logDirectory, "C:");
		}
	}
}
