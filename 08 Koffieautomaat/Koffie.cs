using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieAutomaat
{
	public class Koffie
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
}
