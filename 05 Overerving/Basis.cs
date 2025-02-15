namespace Overerving;

internal class Basis
{
	protected string _naam;
	public Basis()
	{
		_naam = "vaste waarde";
	}
	public virtual void ToonBericht()
	{
		Console.WriteLine("Bericht uit de basis klasse.");
	}
}
