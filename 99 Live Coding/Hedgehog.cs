using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Coding
{
	internal class Hedgehog : Animal, IZoo
	{
		private int _numberOfSpikes;

		public Hedgehog(string name, DateOnly dateOfBirth, int numberOfSpikes) : base(name, dateOfBirth)
		{
			_numberOfSpikes = numberOfSpikes;
		}

		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Number of spikes: {_numberOfSpikes}");
		}
	}
}
