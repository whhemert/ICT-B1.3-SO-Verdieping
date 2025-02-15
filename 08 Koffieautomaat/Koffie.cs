namespace KoffieAutomaat;

internal class Koffie
{
	private int _sterkte;
	private bool _suiker;
	private bool _melk;

	public Koffie(int sterkte, bool suiker, bool melk)
	{
		_sterkte = sterkte;
		_suiker = suiker;
		_melk = melk;
	}
}
