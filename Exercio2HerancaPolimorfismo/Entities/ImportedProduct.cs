using System;
using System.Globalization;
using System.Xml.Linq;

namespace ExercicioDoisPolimorfismoHerança.Entities
{
    public class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            this.customsFee = customFee;
        }
        

        public double totalPrice()
        {
            return price + customsFee;
        }

        public override string priceTag()
        {
            return $"{name} ${totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: ${customsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}

