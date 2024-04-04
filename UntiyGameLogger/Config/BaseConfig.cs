﻿using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UnityGameLogger.Config
{
	internal abstract class BaseConfig
	{
		#region kernel32.dll
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
		#endregion

		public readonly int _configSlot;

		private readonly string _category;
		private readonly string _iniPath;
		public BaseConfig(string category)
		{
			_category = category;

			_iniPath = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\config.ini";
			InitConfig();
		}
		public BaseConfig(int configSlot, string category)
		{
			_configSlot = configSlot;
			_category = category;

			_iniPath = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\config.ini";
			InitConfig();
		}

		protected abstract void InitConfig();

		protected bool HasConfig(string key)
		{
			int ret = GetPrivateProfileString(_category, key, "", new StringBuilder(), 256, _iniPath);
			return ret > 0;
		}

		protected string ReadConfig(string key)
		{
			StringBuilder retVal = new StringBuilder();
			GetPrivateProfileString(_category, key, "", retVal, 256, _iniPath);
			return retVal.ToString();
		}

		protected void EditConfig(string key, string value)
		{
			WritePrivateProfileString(_category, key, value, _iniPath);
		}

		protected void InitOption(string key, ref string field, string defaultValue = "")
		{
			if (HasConfig(key))
			{
				field = ReadConfig(key);
			}
			else
			{
				field = defaultValue;
				EditConfig(key, defaultValue);
			}
		}

		protected void InitOption(string key, ref int field, int defaultValue = 1)
		{
			if (HasConfig(key))
			{
				if (int.TryParse(ReadConfig(key), out int intValue))
				{
					field = intValue;
				}
				else
				{
					field = defaultValue;
					EditConfig(key, defaultValue.ToString());
				}
			}
			else
			{
				field = defaultValue;
				EditConfig(key, defaultValue.ToString());
			}
		}
	}
}
