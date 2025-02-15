using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellableItem
{
	internal class Car : ISellableItem
	{
		private string _make;
		private string _model;
		private string _vin;
		private string _color;

		public Car(string make, string model, string vin, string color)
		{
			_make = make;
			_model = model;
			_vin = vin;
			_color = color;
		}

		public string Identifier()
		{
			return _vin;
		}

		public string ProductInfo()
		{
			return $"{_make} {_model}";
		}
	}
}
