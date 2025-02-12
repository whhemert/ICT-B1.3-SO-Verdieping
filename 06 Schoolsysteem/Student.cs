namespace Schoolsysteem;

public class Student : Persoon
{
    private int _studentNummer;

    public Student(string voorNaam, string achterNaam, DateOnly geboorteDatum, int studentNummer) : base(voorNaam, achterNaam, geboorteDatum)
    {
        _studentNummer = studentNummer;
    }

    public override void PrintInfo()
    {
		Console.WriteLine($"Deze persoon heeft de naam {_voorNaam} {_achterNaam} en is geboren op {_geboorteDatum}");
		Console.WriteLine($"En is student met studentnummer {_studentNummer}");
	}
}