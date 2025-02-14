namespace Schoolsysteem;

// Basis klasse voor het voorbeeld van overerving. Bevat de basis attributen en methoden die elke persoon heeft
public abstract class Persoon
{
	// Door deze attributen protected te maken kunnen de subklassen deze attributen gebruiken (bij private zou dit niet mogelijk zijn)
	protected string _voorNaam;
	protected string _achterNaam;
	protected DateOnly _geboorteDatum;

	// Constuctor waarbij alle attributen van Persoon worden ingevuld
	public Persoon(string voorNaam, string achterNaam, DateOnly geboorteDatum)
    {
        _voorNaam = voorNaam;
        _achterNaam = achterNaam;
        _geboorteDatum = geboorteDatum;
    }

	// Abstracte methode die (omdat hij abstract is) verplicht geïmplementeerd moet worden in subklassen
	public abstract void PrintInfo();
}