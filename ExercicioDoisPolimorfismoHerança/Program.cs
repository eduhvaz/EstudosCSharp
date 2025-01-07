using System.Globalization;
using ExercicioDoisPolimorfismoHerança.Entities;
namespace ExercicioDoisPolimorfismoHerança
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product {i} data: ");
                Console.WriteLine("Common, used or imported(c / u / i) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (ch == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    list.Add(new UsedProduct(name, price, manufacture));
                }
                else if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else
                {
                    Console.WriteLine("Erro");
                }
            }
            Console.WriteLine("PRICE TAGS");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }




        }
    }
}