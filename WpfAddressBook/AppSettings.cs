using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAddressBook {
	class AppSettings : ApplicationSettingsBase {
		public AppSettings() : base(){
		}
		//public int RunCount { get; private set; }

		[UserScopedSetting]
		[DefaultSettingValue("0")]
		public int RunCount {
			get { return (int)this["RunCount"]; }
			set { this["RunCount"] = value; }
		}
	}
}
