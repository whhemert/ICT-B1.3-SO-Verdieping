using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellableItem
{
	public class Phone : ISellableItem
	{
		private string _manufacturer;
		private string _model;
		private long _imei;

		public Phone(string manufacturer, string model, long imei)
		{
			_manufacturer = manufacturer;
			_model = model;
			_imei = imei;
		}

		public string Identifier()
		{
			return Convert.ToString(_imei);
		}

		public string ProductInfo()
		{
			return $"{_manufacturer} {_model}";
		}
	}
}
