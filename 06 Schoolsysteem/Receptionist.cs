namespace Schoolsysteem;

public class Receptionist : Medewerker
{
    private string _vasteLocatie;

    public Receptionist(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris, string vasteLocatie) : base(voorNaam, achterNaam, geboorteDatum, personeelsNummer, salaris)
    {
        _vasteLocatie = vasteLocatie;
    }

    public override void PrintInfo()
	{
		Console.WriteLine($"Deze persoon heeft de naam {_voorNaam} {_achterNaam} en is geboren op {_geboorteDatum}");
		Console.WriteLine($"En is medewerker met personeelsnummer {_personeelsNummer} en een salaris van {_salaris} euro");
		Console.WriteLine($"Als receptionist heeft deze persoon de vaste locatie {_vasteLocatie}");
	}
}