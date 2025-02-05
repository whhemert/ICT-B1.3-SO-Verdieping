using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Sealed
{
	public class AfgeleideKlassse : BasisKlasse
	{	
		public override string AbstractMethod()
		{
			return "needs to be implemented";
		}

		public sealed override void SomeMethod()
		{
			// some other implementation
		}
	}
}
