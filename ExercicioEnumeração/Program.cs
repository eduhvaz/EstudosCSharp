using System;
using enumeração.Entities;
using enumeração.Entities.Enum;
namespace enumeração
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}