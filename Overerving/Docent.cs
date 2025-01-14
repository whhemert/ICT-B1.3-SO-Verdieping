namespace Overerving;

public class Docent : Medewerker
{
    private List<string> _expertiseGebieden;

    public Docent(string voorNaam, string achterNaam, DateOnly geboorteDatum, int personeelsNummer, double salaris) : base(voorNaam, achterNaam, geboorteDatum, personeelsNummer, salaris)
    {
        _expertiseGebieden = new();
    }

    public List<string> ExpertiseGebieden { get { return _expertiseGebieden; } }

    public void AddExpertiseGebied(string expertiseGebied)
    {
        _expertiseGebieden.Add(expertiseGebied);
    }

    public override string Levensdoel()
    {
        return "Studenten begeleiden naar hun diploma";
    }
}