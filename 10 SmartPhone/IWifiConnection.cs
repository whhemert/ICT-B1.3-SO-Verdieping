using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone
{
	public interface IWifiConnection
	{
		public void Connect(string wifiName);
		public void Disconnect();
		public int GetSignalStrength();
	}
}
