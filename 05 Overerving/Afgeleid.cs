namespace Overerving;

internal class Afgeleid : Basis
{
	public override void ToonBericht()
	{
		Console.WriteLine($"Naam : {_naam}");
		base.ToonBericht();
		Console.WriteLine("Aanvullend bericht uit de afgeleide klasse.");
	}
}
