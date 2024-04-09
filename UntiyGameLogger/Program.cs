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
		public static FileSystemWatcher LogFileWatcher;

		[STAThread]
		static void Main()
		{
			LogFileWatcher = new FileSystemWatcher();
			LogFileWatcher.Path = ConfigLoader.Instance.LogConfig.LogDirectory;
			LogFileWatcher.Filter = "Player-*.log";
			LogFileWatcher.NotifyFilter = NotifyFilters.FileName;
			LogFileWatcher.Created += FileSystemWatcher_Changed;
			LogFileWatcher.Renamed += FileSystemWatcher_Changed;
			LogFileWatcher.EnableRaisingEvents = true;
			
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
