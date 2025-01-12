using System.Globalization;
using exercicioPolimorfismoHerança.entities;
namespace exercicioPolimorfismoHerança {
	class Program
	{
		static void Main(string[] args)
		{
			List<Employee> list = new List<Employee>();

			Console.Write("Enter the number of employees: ");
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
                Console.WriteLine($"Employee #{i} data:");
				Console.Write("Outsourced (y/n)? ");
				char ch = char.Parse(Console.ReadLine());
				Console.Write("name: " );
				string name = Console.ReadLine();
				Console.Write("hours: ");
				int hours = int.Parse(Console.ReadLine());
				Console.WriteLine("Value per hour: ");
				double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (ch == 'y')
				{
					Console.WriteLine("Additional charge: ");
					double AddCharge = double.Parse(Console.ReadLine());
					list.Add(new OutsourcedEmployee(name, hours, value, AddCharge));
				}
				else
				{
					list.Add(new Employee(name, hours, value));
				}
            }

            Console.WriteLine("");

			foreach (Employee emp in list)
			{
				Console.WriteLine($"{emp.name} - {emp.payment()}");
			}
		}
	}
}