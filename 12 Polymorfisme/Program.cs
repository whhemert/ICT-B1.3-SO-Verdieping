namespace Polymorfisme;

internal class Program
{
	private static void Main(string[] args)
	{
		// Sheet 22
		Persoon persoon1 = new Persoon("Jan");
		Docent docent1 = new Docent("Jan", 2342);
		Persoon persoon2 = new Docent("Jan", 2342);
		//Docent docent2 = new Persoon("Jan");

		// Sheet 24 (Oefening 3)
		Persoon persoon3 = new Persoon("Pieter");
		//persoon3.P

		Persoon persoon4 = new Docent("Pieter", 45646);
		persoon4.PrintInfo();
		// Dit kan niet als het type Persoon is
		// Console.WriteLine(persoon4.PersoneelsNummer);
	}
}