using System.Globalization;

namespace CalcReceitas
{
    public class Calc
    {
        public string Nome { get; set; }    // Nome do ingrediente
        public double ValorUn { get; set; }  // Valor total pago pelo ingrediente
        public double QtdUn { get; set; }   // Quantidade total em gramas da unidade comprada
        public double Quantidade { get; set; } // Quantidade usada na receita

        public Calc(string nome, double valor, double qtdUn, double quantidade)
        {
            Nome = nome;
            ValorUn = valor;
            QtdUn = qtdUn;
            Quantidade = quantidade;
        }

        public double Calculo()
        {
            // Calcula o valor proporcional
            return (ValorUn / QtdUn) * Quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}: custo proporcional = R$ {Calculo().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
