using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Sealed
{
	public abstract class BasisKlasse
	{
		public abstract string AbstractMethod();
		
		public virtual void SomeMethod()
		{
			// some implementation
		}
	}
}
