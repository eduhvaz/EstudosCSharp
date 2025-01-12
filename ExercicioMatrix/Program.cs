using System;
namespace couse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++){
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++){
                    matrix[i, j] = int.Parse(valor[j]);
                }
            }
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++){
                for (int j = 0; j < n; j++){
                    if (matrix[i, j] == X) {
                        Console.WriteLine($"Position {i} , {j} ");
                    }
                    if (j > 0){
                        Console.WriteLine($"Left: {matrix[i, j - 1]}");
                    }
                    if (i > 0){
                        Console.WriteLine($"Up: {matrix[i - 1, j]}");
                    }
                    if (j < n - 1){
                        Console.WriteLine("Right: " + matrix[i, j + 1]);
                    }
                    if (i < m - 1){
                        Console.WriteLine("Down: " + matrix[i + 1, j]);
                    }

                }

            }
        }
    }
}
    