using System;
using enumeração.Entities.Enum;
namespace enumeração.Entities
{
	public class Order
	{
		public int id { get; set; }
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{id} , {Moment} , {Status}";
        }
    }
}

