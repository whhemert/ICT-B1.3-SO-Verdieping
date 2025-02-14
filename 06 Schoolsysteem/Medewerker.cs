namespace Schoolsysteem;

// Medewerker is een subklasse van Persoon en erft dus de attributen van Persoon
public abstract class Medewerker : Persoon
{
	// Deze attributen worden toegevoegd aan de attributen die geerft worden van Persoon
	protected int _personeelsNummer;
	protected double _salaris;

	// Constructor van de Medewerker klasse waarbij alle attributen van Medewerker en Persoon worden ingevuld
	public Medewerker(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris) : base(voorNaam, achterNaam, geboorteDatum)
    {
        _personeelsNummer = personeelsNummer;
        _salaris = salaris;
    }

	// Alternatieve (overloaded) constuctor van de Medewerker klasse waarbij salaris niet bekend is
	public Medewerker(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer) : base(voorNaam, achterNaam, geboorteDatum)
	{
		_personeelsNummer = personeelsNummer;
		// _salaris krijgt de detault waarde van 0
	}

	// Omdat Medewerker een abstracte klasse is hoeft deze zelf geen implementatie te hebben van de abstracte methode PrintInfo
	// Deze verantwoordelijkheid deligeert deze klasse daardoor door aan de klassen die van Medewerker gaan overerven
}