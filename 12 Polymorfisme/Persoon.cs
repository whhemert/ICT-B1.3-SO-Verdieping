namespace Polymorfisme;

internal class Persoon
{
    protected string _naam;

    public Persoon(string naam)
    {
        _naam = naam;
    }

    public virtual string PrintInfo()
    {
		return $"Naam: {_naam}";
	}
}