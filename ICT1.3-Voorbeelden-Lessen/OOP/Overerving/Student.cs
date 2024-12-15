namespace ICT1._3_Voorbeelden_Lessen.OOP.Overerving;

public class Student : Persoon
{
    private int _studentNummer;

    public Student(string voorNaam, string achterNaam, DateOnly geboorteDatum, int studentNummer) : base(voorNaam, achterNaam, geboorteDatum)
    {
        _studentNummer = studentNummer;
    }

    public int StudentNummer { get { return _studentNummer; } }

    public override string Levensdoel()
    {
        return "Een diploma halen";
    }
}