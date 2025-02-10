using Overerving;

internal class Program
{
    private static void Main(string[] args)
    {
		Console.WriteLine("== Basis ==");
		Basis basis = new Basis();
		basis.ToonBericht();

		Console.WriteLine("== Afgeleid ==");
		Afgeleid afgeleid = new Afgeleid();
		afgeleid.ToonBericht();
	}
}