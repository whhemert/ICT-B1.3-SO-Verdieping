using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieAutomaat
{
	internal interface IKoffieAutomaat
	{
		public Koffie BestelKoffie();

		public Cappuccino BestelCappuccino();

		public Chocomel BestelChocomel();

		public void OnderhoudUitvoeren();
	}
}
