namespace Polymorfisme;

internal class Program
{
	private static void Main(string[] args)
	{
		// Sheet 24
		Dier dier = new Kat("Minoes");
		dier.MaakGeluid(); // Miauwen

		dier = new Hond("Fikkie");
		dier.MaakGeluid(); // Blaffen

		dier = new Ezel("Ezeltje");
		dier.MaakGeluid(); // Balken

		// Sheet 25
		Persoon persoon1 = new Persoon("Jan");
		Docent docent1 = new Docent("Jan", 2342);
		Persoon persoon2 = new Docent("Jan", 2342);
		//Docent docent2 = new Persoon("Jan");

		// Sheet 27 (Oefening 3)
		Persoon persoon3 = new Persoon("Pieter");
		persoon3.PrintInfo(); // Dit is de PrintInfo van de Persoon klasse

		Persoon persoon4 = new Docent("Pieter", 45646);
		persoon4.PrintInfo(); // Dit is de PrintInfo van de Docent klasse

		// Dit kan niet als het type Persoon is
		// Console.WriteLine(persoon4.PersoneelsNummer);
	}
}