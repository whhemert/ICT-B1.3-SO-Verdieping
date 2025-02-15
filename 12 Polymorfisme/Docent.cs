namespace Polymorfisme;

internal class Docent : Persoon
{
    private long _personeelsNummer;

    public Docent(string naam, long personeelsNummer) : base(naam)
	{
        _personeelsNummer = personeelsNummer;
    }

    public long PersoneelsNummer { get { return _personeelsNummer; } }

	public override string PrintInfo()
	{
		base.PrintInfo();
		return $"Naam: {_naam}, Personeelsnummer: {_personeelsNummer}";
	}
}