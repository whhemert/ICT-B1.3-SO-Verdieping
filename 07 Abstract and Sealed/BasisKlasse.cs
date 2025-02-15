namespace Abstract_and_Sealed;

public abstract class BasisKlasse
{
	public abstract string AbstractMethod();
	
	public virtual void SomeMethod()
	{
		Console.WriteLine("SomeMethod in BasisKlasse");
	}
}
