namespace Polymorfisme;

public class Persoon
{
    private string _naam;

    public Persoon(string naam)
    {
        _naam = naam;
    }

    public string Naam { get { return _naam; } }

    public virtual string MethodeNaam()
    {
        return "Dit is de basis implementatie van MethodeNaam voor de klasse Persoon";
    }
}