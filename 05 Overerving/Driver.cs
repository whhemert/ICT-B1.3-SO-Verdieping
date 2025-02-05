public class Driver : Person
{
    private long _driverLicenceNumber;
    private DateTime _driverLicenceValidUntil;

    public Driver(string name, DateTime birthDay, long driverLicenceNumber, DateTime driverLicenceValidUntil) : base(name, birthDay)
	{
		_driverLicenceNumber = driverLicenceNumber;
		_driverLicenceValidUntil = driverLicenceValidUntil;
	}

    public void PrintDriverDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Birth Day: {_birthDay.ToShortDateString()}");
        Console.WriteLine($"Driver Licence Number: {_driverLicenceNumber}");
        Console.WriteLine($"Licence Valid Until: {_driverLicenceValidUntil.ToShortDateString()}");
    }
}