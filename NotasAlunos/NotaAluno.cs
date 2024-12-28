using System;
using System.Globalization;

namespace NotasAlunos
{
	public class Aluno
	{
		public string nome;
		public double n1, n2, n3;

		public double CalcSoma()
		{
            return n1 + n2 + n3;
            
        }
        public void ExibiRes()
        {
            double soma = CalcSoma();
            Console.WriteLine($"Soma das notas: {soma}");

            if (soma < 60)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }


    }
}

