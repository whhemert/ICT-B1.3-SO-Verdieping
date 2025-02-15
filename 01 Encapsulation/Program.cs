namespace Encapsulation;

internal class Program
{
	private static void Main(string[] args)
	{
		Pet dog = new Pet("Rex");
		Pet cat = new Pet("Minoes");

		// waarom werkt dit niet?
		dog.SetName("");
		Console.WriteLine(dog.Name());
	}
}