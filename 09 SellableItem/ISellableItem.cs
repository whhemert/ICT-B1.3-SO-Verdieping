using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellableItem
{
	internal interface ISellableItem
	{
		public string ProductInfo();
		public string Identifier();
	}
}
