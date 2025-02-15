namespace Schoolsysteem;

// Student is een subklasse van Persoon en erft dus de attributen van Persoon
internal class Student : Persoon
{
	// Deze attributen worden toegevoegd aan de attributen die geerft worden van Persoon
	private int _studentNummer;

	// Constructor van de Student klasse waarbij alle attributen van Student en Persoon worden ingevuld
	public Student(string voorNaam, string achterNaam, DateOnly geboorteDatum, int studentNummer) : base(voorNaam, achterNaam, geboorteDatum)
    {
        _studentNummer = studentNummer;
    }

	// Print alle informatie over de Student door het implementeren van de abstracte methode PrintInfo die in Persoon vastgelegd is
	public override void PrintInfo()
    {
		Console.WriteLine($"Deze persoon heeft de naam {_voorNaam} {_achterNaam} en is geboren op {_geboorteDatum}");
		Console.WriteLine($"En is student met studentnummer {_studentNummer}");
	}
}