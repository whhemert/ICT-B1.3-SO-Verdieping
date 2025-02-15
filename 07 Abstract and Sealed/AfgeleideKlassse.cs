namespace Abstract_and_Sealed;

internal class AfgeleideKlassse : BasisKlasse
{
	public override string AbstractMethod()
	{
		return "needs to be implemented here";
	}

	public sealed override void SomeMethod()
	{
		Console.WriteLine("SomeMethod in AfgeleideKlassse");
	}
}
