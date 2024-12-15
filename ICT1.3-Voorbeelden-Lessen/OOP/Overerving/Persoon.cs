namespace ICT1._3_Voorbeelden_Lessen.OOP.Overerving;

public abstract class Persoon
{
    private static int _counter = 0;
    private string _voorNaam;
    private string _achterNaam;
    private DateOnly _geboorteDatum;

    public Persoon(string voorNaam, string achterNaam, DateOnly geboorteDatum)
    {
        _voorNaam = voorNaam;
        _achterNaam = achterNaam;
        _geboorteDatum = geboorteDatum;
    }

    public string VoorNaam { get { return _voorNaam; } }
    public string AchterNaam { get { return _achterNaam; } }
    public DateOnly GeboorteDatum { get { return _geboorteDatum; } }
    public int Counter { get { return _counter; }set { _counter = value;}}

    public virtual string Levensdoel()
    {
        return "De wereld beter achter laten";
    }

    public string PersoonInfo()
    {
        return $"{_voorNaam} {_achterNaam} is geboren op {_geboorteDatum}";
    }
}