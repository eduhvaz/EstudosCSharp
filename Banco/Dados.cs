using System.Globalization;

namespace Banco1
{
	public class Dados
	{
        private int numero;

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public Dados(int conta, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Dados(int numero, string titular, double depositoinicial) : this(numero, titular) 
        {
            Deposito(depositoinicial);
        }

        public void Deposito(double quantia)
		{
		    if (quantia > 0) // Verifica se o valor do depósito é válido
            {
                Saldo += quantia; // Adiciona ao saldo
            }
             
		}
		public void Saque(double quantia)
		{
            double taxa = 5.00; // Taxa fixa por saque
            if (quantia + taxa <= Saldo) // Verifica se há saldo suficiente
            {
                Saldo -= (quantia + taxa); // Subtrai o valor sacado e a taxa
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }

        }
        public override string ToString()
        {
            return $"Conta: {Numero}, Titular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

}
