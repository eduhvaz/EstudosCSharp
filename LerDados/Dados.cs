using System.Globalization;
namespace LerDados
{
	public class Dados
	{
		public string Nome;
		public double Salario;
		public double Imposto;

		public double SalarioLiquido()
		{
			return Salario - Imposto;
		}


		public void AumentarSalario(double porcentagem)
		{
			Salario *= (1 + porcentagem / 100);
		}
		public override string ToString()
		{
            return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
		}
    }
    
}

