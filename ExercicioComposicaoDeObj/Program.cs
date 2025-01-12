using System;
using System.Globalization;
using ComposiçãoDeObj.Entities;
using ComposiçãoDeObj.Entities.Enums;

namespace ComposicaoDeObj
{
    class Program
    {
        static void Main(String[] args)
        {

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior / MidLevel / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            int baseSalary = int.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter n{i} contract data:");
                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string MonthAndYear = Console.ReadLine();
            int month = int.Parse(MonthAndYear.Substring(0, 2));
            int year = int.Parse(MonthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.name);
            Console.WriteLine("Departament: " + worker.department.name );
            Console.WriteLine($"Income for {MonthAndYear}: {worker.Income(year, month)}");
        }
    }
}