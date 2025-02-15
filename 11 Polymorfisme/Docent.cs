namespace Polymorfisme;

internal class Docent : Persoon
{
    private long _personeelsNummer;

    public Docent(string naam, long personeelsNummer) : base(naam)
	{
        _personeelsNummer = personeelsNummer;
    }

    public long PersoneelsNummer { get { return _personeelsNummer; } }

	public override string MethodeNaam()
	{
		return "Totaal random andere implementatie voor docent, chaos!";
	}
}