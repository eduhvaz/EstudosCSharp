
using Retangulo1;


namespace MeuProgram
{
    class Program
    {
        static void Main(string[] args) {

            Retangulo a = new Retangulo();

            Console.Write("digite a Altura do Retangulo ");
            a.Altura = double.Parse(Console.ReadLine());
            Console.Write("digite a largura do Retangulo ");
            a.Largura = double.Parse(Console.ReadLine());

            Console.Write(a);

            Console.Read();


        }
    }
}

