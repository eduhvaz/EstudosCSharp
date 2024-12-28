using System;
using Classes1;
using System.Globalization;
    static void Main(string[] args)
{
    //dados:

    Pessoas x, y;
    x = new Pessoas();
    y = new Pessoas();

    //entrada de dados:
    Console.WriteLine("Escreva");
    x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //Saida de dados:
    Console.WriteLine("a pessoas tem " + x + "de altura" + "e" + y + "de peso corporal");

}
