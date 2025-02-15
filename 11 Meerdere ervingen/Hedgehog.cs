namespace Meerdere_Ervingen;

internal class Hedgehog : Animal, IZoo
{
	private int _numberOfSpikes;

	public Hedgehog(string name, DateOnly dateOfBirth, int numberOfSpikes) : base(name, dateOfBirth)
	{
		_numberOfSpikes = numberOfSpikes;
	}

	public override void PrintInfo()
	{
		base.PrintInfo();
		Console.WriteLine($"Number of spikes: {_numberOfSpikes}");
	}
}
