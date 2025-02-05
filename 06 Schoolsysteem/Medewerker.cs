namespace Schoolsysteem;

public abstract class Medewerker : Persoon
{
    private int _personeelsNummer;
    private double _salaris;

    public Medewerker(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris) : base(voorNaam, achterNaam, geboorteDatum)
    {
        _personeelsNummer = personeelsNummer;
        _salaris = salaris;
    }

    public int PersoneelsNummer { get { return _personeelsNummer; } }
    public double Salaris { get { return _salaris; } }
}