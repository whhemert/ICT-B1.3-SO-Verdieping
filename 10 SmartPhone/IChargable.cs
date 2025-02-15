using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone
{
	internal interface IChargable
	{
		public void Charge(int increasedPercentace);
		public void PrintChargeInfo();
	}
}
