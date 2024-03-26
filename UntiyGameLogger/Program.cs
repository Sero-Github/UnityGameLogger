using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using UnityGameLogger.Config;

namespace UnityGameLogger
{
	internal static class Program
	{
		/// <summary>
		/// 해당 애플리케이션의 주 진입점입니다.
		/// </summary>
		public static FileSystemWatcher LogFileWatcher1;
		public static FileSystemWatcher LogFileWatcher2;
		public static FileSystemWatcher[] LogFileWatchers;

		public static ConfigLoader configLoader;
		[STAThread]
		static void Main()
		{
			LogFileWatchers = new FileSystemWatcher[]
			{
				LogFileWatcher1 = new FileSystemWatcher(),
				LogFileWatcher2 = new FileSystemWatcher()
			};

			configLoader = new ConfigLoader();

			foreach (FileSystemWatcher watcher in LogFileWatchers)
			{
				int index = Array.IndexOf(LogFileWatchers, watcher);
				if (Directory.Exists(configLoader.LogConfigs[index].LogDirectory))
				{
					watcher.Path = configLoader.LogConfigs[index].LogDirectory;
					watcher.Filter = "Player-*.log";
					watcher.NotifyFilter = NotifyFilters.FileName;
					watcher.Created += FileSystemWatcher_Changed;
					watcher.Renamed += FileSystemWatcher_Changed;
					watcher.EnableRaisingEvents = true;
				}
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

		}
		private static void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
		{
			try
			{
				if (File.Exists(e.FullPath))
				{
					FileInfo info = new FileInfo(e.FullPath);
					string logDirectory = Path.GetDirectoryName(e.FullPath);
					string logPath = Path.Combine(logDirectory, $"{info.LastWriteTime:yyyy-MM-dd_HHmmss}_Player.log");

					Thread.Sleep(2000);

					File.Move(e.FullPath, logPath);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
