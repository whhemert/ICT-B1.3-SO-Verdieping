using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
	internal class Kat : Dier
	{
		public Kat(string name) : base(name)
		{
			// no implementation here
		}

		public override void MaakGeluid()
		{
			Console.WriteLine("Miauw");
		}
	}
}
