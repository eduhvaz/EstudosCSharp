using System;
using System.Diagnostics;
using System.Globalization;

namespace ExercicioDoisPolimorfismoHerança.Entities
{
	public class Product
	{
		public string name { get; set; }
		public double price { get; set; }

		public Product()
		{
		}

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public virtual string priceTag()
        {
			return $"{name} ${price.ToString("F2", CultureInfo.InvariantCulture)}" ;
		}
    }
}

