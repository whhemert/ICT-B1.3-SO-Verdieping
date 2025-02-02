namespace Overloading
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Person person = new Person("John Doe");
			Console.WriteLine($"Naam: {person.Name}, Geboortedatum: {person.DateOfBirth.ToShortDateString()}");

			person.UpdateDateOfBirth(2000, 1, 1);
			Console.WriteLine($"Nieuwe geboortedatum: {person.DateOfBirth.ToString("D")}");

			person.UpdateDateOfBirth(new DateTime(2022, 12, 12));
			Console.WriteLine($"Nieuwe geboortedatum: {person.DateOfBirth.ToString("D")}");

			person.UpdateDateOfBirth("2010-10-13");
			Console.WriteLine($"Nieuwe geboortedatum: {person.DateOfBirth.ToString("D")}");
		}
	}
}