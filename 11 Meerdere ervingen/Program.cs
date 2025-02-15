namespace Meerdere_Ervingen;

internal class Program
{
	private static void Main(string[] args)
	{
		Hedgehog hedgehog = new Hedgehog("Sonic", new DateOnly(1991, 6, 23), 7000);
		hedgehog.PrintInfo();
	}
}