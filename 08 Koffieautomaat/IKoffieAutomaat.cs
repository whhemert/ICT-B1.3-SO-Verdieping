namespace KoffieAutomaat;

internal interface IKoffieAutomaat
{
	public Koffie BestelKoffie();

	public Cappuccino BestelCappuccino();

	public Chocomel BestelChocomel();

	public void OnderhoudUitvoeren();
}
