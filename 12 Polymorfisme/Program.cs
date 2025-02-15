namespace Polymorfisme;

internal class Program
{
	private static void Main(string[] args)
	{
		//Persoon persoon1 = new Persoon("Jan");
		//Console.WriteLine(persoon1.MethodeNaam());

		//Persoon persoon2 = new Docent("Jan", 11243);
		//Console.WriteLine(persoon2.MethodeNaam());

		Persoon persoon1 = new Persoon("Jan");
		Docent docent1 = new Docent("Jan", 2342);
		Persoon persoon2 = new Docent("Jan", 2342);
		Docent docent2 = new Persoon("Jan");

	}
}