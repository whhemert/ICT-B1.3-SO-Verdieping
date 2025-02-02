// Example usage
class Program
{
	static void Main()
	{
		// Create a Driver object
		Driver driver = new Driver("John Doe", new DateTime(1985, 5, 20), 1234567890, new DateTime(2026, 12, 31));

		// Display initial details
		driver.PrintDriverDetails();

		// Update the driver's licence
		driver.UpdateDriverLicence(9876543210, new DateTime(2030, 12, 31));

		// Display updated details
		Console.WriteLine("\nAfter updating license:");
		driver.PrintDriverDetails();
	}
}