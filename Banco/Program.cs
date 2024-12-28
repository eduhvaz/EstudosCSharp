using System.Globalization;
using Banco1;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome1 = (Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            Dados d = new Dados(numero, nome1);

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                d.Deposito(double.Parse(Console.ReadLine()));
            }
           
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(d);
            

            Console.WriteLine();
            Console.WriteLine("Entre um valor para depósito:");
            d.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(d);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            d.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(d);
        }
    }
}
    