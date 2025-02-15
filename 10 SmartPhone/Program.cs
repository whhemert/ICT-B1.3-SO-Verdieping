namespace SmartPhone;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("\n== phone1 ==");
		IChargable phone1 = new SamsungS25();
		phone1.Charge(50);
		phone1.PrintChargeInfo();

		Console.WriteLine("\n== phone2 ==");
		IWifiConnection phone2 = new SamsungS25();
		phone2.Connect("PublicNetwork");
		Console.WriteLine($"Current signal strength {phone2.GetSignalStrength()}");
		phone2.Disconnect();

		Console.WriteLine("\n== phone3 ==");
		SamsungS25 phone3 = new SamsungS25();
		phone3.Charge(34);
		phone3.PrintChargeInfo();
		phone3.Connect("HomeNetwork");
		Console.WriteLine($"Current signal strength {phone3.GetSignalStrength()}");
		phone3.Disconnect();
	}
}