namespace UnityGameLogger.Config.Option
{
	internal class GameConfig : BaseConfig
	{
		private string _gameDirectory;
		private string _gameFile;
		private string _gameMemo;
		private int _gameExecuteCount;

		public GameConfig(int ConfigSlot) : base(ConfigSlot, $"GAME{ConfigSlot}") { }

		public string GameDirectory
		{
			get { return _gameDirectory; }
			set
			{
				_gameDirectory = value;
				EditConfig("GAME_PATH", value);
			}
		}

		public string GameFile
		{
			get { return _gameFile; }
			set
			{
				_gameFile = value;
				EditConfig("GAME_FILE", value);
			}
		}

		public string GameMemo
		{
			get { return _gameMemo; }
			set
			{
				_gameMemo = value;
				EditConfig("GAME_MEMO", value);
			}
		}

		public int GameExecuteCount
		{
			get { return _gameExecuteCount; }
			set
			{
				_gameExecuteCount = value;
				EditConfig("GAME_EXECUTE_COUNT", _gameExecuteCount.ToString());
			}
		}

		protected override void InitConfig()
		{
			InitOption("GAME_PATH", ref _gameDirectory);
			InitOption("GAME_FILE", ref _gameFile);
			InitOption("GAME_MEMO", ref _gameMemo);
			InitOption("GAME_EXECUTE_COUNT", ref _gameExecuteCount, 1);
		}
	}
}
