using System;

namespace Course{
        class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Digite um numero");
            int a =  int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite um numero");
            int b =  int.Parse(Console.ReadLine());
            if (a % b == 0 || b % a == 0 )
                System.Console.WriteLine("sao multiplos");
            else
            System.Console.WriteLine("nao sao");

        }
    }
}