using System;
using System.Globalization;

namespace ExercicioDoisPolimorfismoHerança.Entities
{
	public class UsedProduct : Product
	{
		public DateTime manufacture { get; set; }

		public UsedProduct()
		{
		}
		public UsedProduct(string name, double price, DateTime manufacture)
			: base(name, price)
        {
            this.manufacture = manufacture;
        }
        public override string priceTag()
        {
            return $"{name} ${price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {manufacture} ";
        }

    }
}

