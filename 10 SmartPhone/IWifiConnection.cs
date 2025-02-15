namespace SmartPhone;

internal interface IWifiConnection
{
	public void Connect(string wifiName);
	public void Disconnect();
	public int GetSignalStrength();
}