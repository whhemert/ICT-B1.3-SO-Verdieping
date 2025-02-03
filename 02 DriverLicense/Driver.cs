public class Driver
{
    private string _name;
    private DateTime _birthDay;
    private long _driverLicenceNumber;
    private DateTime _driverLicenceValidUntil;

    public Driver(string name, DateTime birthDay)
    {
        _name = name;
        _birthDay = birthDay;
    }

    public void UpdateDriverLicence(long driverLicenceNumber, DateTime driverLicenceValidUntil)
    {
        if (driverLicenceNumber >= 1_000_000)
        {
            _driverLicenceNumber = driverLicenceNumber;
            _driverLicenceValidUntil = driverLicenceValidUntil;
        } else
        {
            Console.WriteLine("Invalid driver licence number");
		}
    }

    public void PrintDriverDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Birth Day: {_birthDay.ToShortDateString()}");
        Console.WriteLine($"Driver Licence Number: {_driverLicenceNumber}");
        Console.WriteLine($"Licence Valid Until: {_driverLicenceValidUntil.ToShortDateString()}");
    }
}