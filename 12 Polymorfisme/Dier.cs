using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
	internal abstract class Dier
	{
		private string _name;

		public Dier(string name)
		{
			_name = name;
		}

		public abstract void MaakGeluid();
	}
}
