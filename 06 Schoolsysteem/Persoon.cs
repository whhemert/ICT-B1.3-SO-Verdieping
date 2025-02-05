namespace Schoolsysteem;

public abstract class Persoon
{
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

    public abstract string ActiviteitOfDoel();
}