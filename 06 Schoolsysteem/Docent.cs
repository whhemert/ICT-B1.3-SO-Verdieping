namespace Schoolsysteem;

public class Docent : Medewerker
{
    private List<string> _expertiseGebieden;

    public Docent(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris) : base(voorNaam, achterNaam, geboorteDatum, personeelsNummer, salaris)
    {
        _expertiseGebieden = new();
    }

    public void AddExpertiseGebied(string expertiseGebied)
    {
        _expertiseGebieden.Add(expertiseGebied);
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Deze persoon heeft de naam {_voorNaam} {_achterNaam} en is geboren op {_geboorteDatum}");
		Console.WriteLine($"En is medewerker met personeelsnummer {_personeelsNummer} en een salaris van {_salaris} euro");
		Console.WriteLine($"Als docent heeft deze persoon de expertise gebieden {String.Join(", ", _expertiseGebieden)}");
	}
}