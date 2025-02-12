namespace Schoolsysteem;

public abstract class Persoon
{
    protected string _voorNaam;
	protected string _achterNaam;
	protected DateOnly _geboorteDatum;

    public Persoon(string voorNaam, string achterNaam, DateOnly geboorteDatum)
    {
        _voorNaam = voorNaam;
        _achterNaam = achterNaam;
        _geboorteDatum = geboorteDatum;
    }

    public abstract void PrintInfo();
}