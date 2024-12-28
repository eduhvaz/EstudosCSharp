using System;
using System.Globalization;

namespace Exercicio0{
    class Program{
        static void Main(string[] args){
            //variaves
            string produto1 = "computador";
            string produto2 = "mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //tela
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1:F2}");
            Console.WriteLine(produto1 + ",cujo o preço é $" + preco2.ToString("F2"));
            System.Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero {genero}.");
            System.Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais:{medida:F8}");
            Console.WriteLine($"Arredondamento (tres casas decimais):{medida:F3}");
            Console.WriteLine("Separador decimal invarent culture:" + medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}