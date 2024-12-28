using System;
using System.Globalization;
using NotasAlunos;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno = new Aluno();

            Console.WriteLine("Nome do aluno " + Aluno.nome);
            Console.Write("Nota 1: ");
            Aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            Aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            Aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Aluno);

            Aluno.ExibiRes();


        }
    }
}