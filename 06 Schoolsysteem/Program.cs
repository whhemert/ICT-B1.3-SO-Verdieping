namespace Schoolsysteem;

internal class Program
{
	private static void Main(string[] args)
	{
		// Maak een Student aan en print de informatie
		Console.WriteLine("== student ==");
		Student student = new Student("Jan", "Peters", new DateOnly(2006, 5, 17), 101001);
		student.PrintInfo();

		// Maak een Docent aan, voeg expertiesegebieden toe en print de informatie
		Console.WriteLine("\n== docent ==");
		Docent docent = new Docent("Fred", "Fakkel", new DateOnly(2002, 6, 17), 202002, 2000);
		docent.AddExpertiseGebied("C#");
		docent.AddExpertiseGebied("Unity");
		docent.AddExpertiseGebied("Scrum");
		docent.PrintInfo();

		// Maak een Receptionist aan en print de informatie, zonder dat er een salaris bekend is (overloaded constructor medewerker)
		Console.WriteLine("\n== receptionist ==");
		Persoon receptionist = new Receptionist("Peter", "Janssen", new DateOnly(1978, 3, 1), 564654, "Avans Lovensdijkstraat");
		// Alternatief voor als het salaris wel bekend is
		//Persoon receptionist = new Receptionist("Peter", "Janssen", new DateOnly(1978, 3, 1), 564654, 1500, "Avans Lovensdijkstraat");
		receptionist.PrintInfo();
	}
}