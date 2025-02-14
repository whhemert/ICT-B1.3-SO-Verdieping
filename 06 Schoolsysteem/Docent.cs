namespace Schoolsysteem;

// Docent is een subklasse van Medewerker en erft dus de attributen van Medewerker
public class Docent : Medewerker
{
	// Deze attributen worden toegevoegd aan de attributen die geerft worden van Medewerker
	private List<string> _expertiseGebieden;

	// Constructor van de Docent klasse waarbij alle attributen van Docent, Medewerker en Persoon worden ingevuld
	public Docent(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris) : base(voorNaam, achterNaam, geboorteDatum, personeelsNummer, salaris)
    {
        _expertiseGebieden = new();
    }

	// Methode om een expertise gebied toe te voegen aan de lijst van expertise gebieden
	public void AddExpertiseGebied(string expertiseGebied)
    {
        _expertiseGebieden.Add(expertiseGebied);
    }

	// Print alle informatie over de Docent door het implementeren van de abstracte methode PrintInfo die in Persoon vastgelegd is
	public override void PrintInfo()
    {
        Console.WriteLine($"Deze persoon heeft de naam {_voorNaam} {_achterNaam} en is geboren op {_geboorteDatum}");
		Console.WriteLine($"En is medewerker met personeelsnummer {_personeelsNummer} en een salaris van {_salaris} euro");
		Console.WriteLine($"Als docent heeft deze persoon de expertise gebieden {String.Join(", ", _expertiseGebieden)}");
	}
}