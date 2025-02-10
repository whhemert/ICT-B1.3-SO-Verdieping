using System.Xml.Linq;

public class Driver : Person
{
	private long _licenceNumber;
	private DateTime _validUntil;

	public Driver(string name, DateTime birthDay, long licenceNumber, DateTime validUntil) : base(name, birthDay)
	{
		_licenceNumber = licenceNumber;
		_validUntil = validUntil;
	}

	public void PrintDriverDetails()
	{
		Console.WriteLine($"Name: {_name}");
		Console.WriteLine($"Birth Day: {_birthDay.ToShortDateString()}");
		Console.WriteLine($"Licence Number: {_licenceNumber}");
		Console.WriteLine($"Licence Valid Until: {_validUntil.ToShortDateString()}");
	}

	public override string ToString()
	{
		return $"Name: {_name}, " +
			$"Birth Day: {_birthDay.ToShortDateString()}, " +
			$"Licence Number: {_licenceNumber}, " +
			$"Licence Valid Until: {_validUntil.ToShortDateString()}";
	}
}