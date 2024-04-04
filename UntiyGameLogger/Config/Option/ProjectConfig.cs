using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityGameLogger.Config.Option
{
	internal class ProjectConfig : BaseConfig
	{
		private string _projectName;

		public string ProjectName
		{
			get { return _projectName; }
			set
			{
				_projectName = value;
				EditConfig("NAME", value);
			}
		}

		public ProjectConfig() : base("PROJECT") { }

		protected override void InitConfig()
		{
			InitOption("NAME", ref _projectName);
		}
	}
}
