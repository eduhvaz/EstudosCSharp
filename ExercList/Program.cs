using System;
using System.Collections.Generic;
using ExercList;
namespace ExercList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> listEmp = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            double qtdEmp = int.Parse(Console.ReadLine());

            // Loop FOR para inserir os dados dos funcionários
            for (int i = 0; i < qtdEmp; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = (Console.ReadLine());

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                // Adiciona o funcionário na lista
                listEmp.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }    
            // Solicita o ID do funcionário que terá o salário aumentado
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            // Verifica se o ID existe na lista e aumenta o salário
            Employee emp = listEmp.Find(x => x.id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            // Imprime a lista atualizada dos funcionários
            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee obj in listEmp)
            {
                Console.WriteLine(obj);
            }

        }

    }
}