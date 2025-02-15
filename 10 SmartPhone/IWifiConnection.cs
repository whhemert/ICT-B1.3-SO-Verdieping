using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone
{
	internal interface IWifiConnection
	{
		public void Connect(string wifiName);
		public void Disconnect();
		public int GetSignalStrength();
	}
}
