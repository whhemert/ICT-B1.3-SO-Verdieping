using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieAutomaat
{
	public class Chocomel
	{
		protected string _booze;
		protected bool _slagroom;

		public Chocomel(string booze, bool slagroom)
		{
			_booze = booze;
			_slagroom = slagroom;
		}
	}
}
