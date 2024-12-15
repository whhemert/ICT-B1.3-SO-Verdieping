namespace ICT1._3_Voorbeelden_Lessen.OOP.Overerving;

public class Receptionist : Medewerker
{
    private string _vasteLocatie;

    public Receptionist(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris, string vasteLocatie) : base(voorNaam, achterNaam, geboorteDatum, personeelsNummer, salaris)
    {
        _vasteLocatie = vasteLocatie;
    }

    public string VasteLocatie { get { return _vasteLocatie; } }

    public override string Levensdoel() {
        return "Gebouwen draaiende houden";
    }
}