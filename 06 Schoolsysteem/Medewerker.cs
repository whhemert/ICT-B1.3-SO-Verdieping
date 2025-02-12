namespace Schoolsysteem;

public abstract class Medewerker : Persoon
{
	protected int _personeelsNummer;
	protected double _salaris;

    public Medewerker(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris) : base(voorNaam, achterNaam, geboorteDatum)
    {
        _personeelsNummer = personeelsNummer;
        _salaris = salaris;
    }
}