namespace Overerving
{
	public class Afgeleid : Basis
	{
		public override void ToonBericht()
		{
			Console.Write(_naam);
			base.ToonBericht();
		}
	}
}
