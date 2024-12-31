using System;
using System.Globalization;
using ExercícioProposto_EnumeraçõesEComposição_.Entities;
using ExercícioProposto_EnumeraçõesEComposição_.Entities.Enum;
namespace ExercícioProposto_EnumeraçõesEComposição_

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Birth date(DD / MM / YYYY): ");
            DateTime Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(Name, Email, Date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Quatity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price, new Product (name, price));
                
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}

