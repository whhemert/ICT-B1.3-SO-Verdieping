namespace Schoolsysteem;

// Receptionist is een subklasse van Medewerker en erft dus de attributen van Medewerker
public class Receptionist : Medewerker
{
	// Deze attributen worden toegevoegd aan de attributen die geerft worden van Medewerker
	private string _vasteLocatie;

	// Constructor van de Receptionist klasse waarbij alle attributen van Receptionist, Medewerker en Persoon worden ingevuld
	public Receptionist(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris, string vasteLocatie) : base(voorNaam, achterNaam, geboorteDatum, personeelsNummer, salaris)
	{
		_vasteLocatie = vasteLocatie;
	}

	// Overloaded constructor van de Receptionist klasse waarbij salaris onbekend is. Daardoor wordt ook de overloaded constructor van Medewerker aangeroepen
	public Receptionist(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, string vasteLocatie) : base(voorNaam, achterNaam, geboorteDatum, personeelsNummer)
    {
        _vasteLocatie = vasteLocatie;
    }

	// Print alle informatie over de Receptionist door het implementeren van de abstracte methode PrintInfo die in Persoon vastgelegd is
	public override void PrintInfo()
	{
		Console.WriteLine($"Deze persoon heeft de naam {_voorNaam} {_achterNaam} en is geboren op {_geboorteDatum}");
		if (_salaris == 0)
		{
			Console.WriteLine($"En is medewerker met personeelsnummer {_personeelsNummer} (salaris onbekend)");
		}
		else
		{
			Console.WriteLine($"En is medewerker met personeelsnummer {_personeelsNummer} en een salaris van {_salaris} euro");
		}
		Console.WriteLine($"Als receptionist heeft deze persoon de vaste locatie {_vasteLocatie}");
	}
}