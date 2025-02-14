using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone
{
	internal class SamsungS25 : IChargable, IWifiConnection
	{
		private int _batteryPercentage;
		private bool _connectedToWifi;
		private int _wifiSignalStrengh;
		private string _connectedWifiName = "";

		public void Charge(int increasedPercentace)
		{
			_batteryPercentage = Math.Min(100, _batteryPercentage + increasedPercentace);
		}

		public void Connect(string wifiName)
		{
			_connectedToWifi = true;
			_connectedWifiName = wifiName;
			_wifiSignalStrengh = new Random().Next(0, 100);
		}

		public void Disconnect()
		{
			_connectedToWifi = false;
			_connectedWifiName = "";
			_wifiSignalStrengh = 0;
		}

		public int GetSignalStrength()
		{
			return _wifiSignalStrengh;
		}

		public void PrintChargeInfo()
		{
			Console.WriteLine($"Current battery percentage: {_batteryPercentage}");
		}
	}
}
