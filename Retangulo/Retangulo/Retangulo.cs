using System;
namespace Retangulo1{
	public class Retangulo{
		public double Altura, Largura;

		public double Area()
		{
			return Altura * Largura;
		}
		public double Perimetro()
		{
			return 2 * (Altura + Largura);
		}
		public double Diagonal()
		{
			return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));

		}
        public override string ToString()
        {
			return " AREA = " + Area() + " PERIMETRO = " + Perimetro() + " DIAGONAL = " + Diagonal();
				
        }
    }
}