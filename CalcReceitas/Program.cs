using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalcReceitas
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Calc> ingredientes = new List<Calc>();
            double custoTotal = 0.0;

            Console.WriteLine("Cadastro de ingredientes para a receita:");
            while (true)
            {
                Console.WriteLine();
                Console.Write("Digite o nome do ingrediente (ou 'sair' para finalizar): ");
                string nome = Console.ReadLine();
                

                if (nome.ToLower() == "sair")
                {
                    break;
                }

                Console.Write("Digite o valor total pago pelo ingrediente (em reais): ");
                double valorUn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Digite o peso total da unidade comprada (em gramas): ");
                double qtdUn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Digite o peso usado na receita (em gramas): ");
                double qtdReceita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (valorUn <= 0 || qtdUn <= 0 || qtdReceita <= 0)
                {
                    Console.WriteLine("Erro: valores inseridos devem ser maiores que zero.");
                    continue;
                }

                Calc calc = new Calc(nome, valorUn, qtdUn, qtdReceita);
                ingredientes.Add(calc);
                custoTotal += calc.Calculo();
            }

            Console.WriteLine("\nResumo da receita:");
            foreach (var ingrediente in ingredientes)
            {
                Console.WriteLine(ingrediente);
            }

            Console.WriteLine($"\nCusto total da receita: R$ {custoTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
