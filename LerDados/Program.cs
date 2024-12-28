using System;
using System.Globalization;
using LerDados;

namespace MeuProgram {
    class Pessoa
    {
        static void Main(string[] args) {

            Dados Pessoa1 = new Dados();

            Console.Write("Digite seu nome: ");
            Pessoa1.Nome = (Console.ReadLine());
            Console.Write("Digite seu Salario Bruto: ");
            Pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o imposto: ");
            Pessoa1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + Pessoa1);

            Console.WriteLine();
            Console.WriteLine("Digite porcetagem para aumentar o salario:");
            double Porc = double.Parse(Console.ReadLine());
            Pessoa1.AumentarSalario(Porc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + Pessoa1);

        }
    }
}