using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] auxiliar = Console.ReadLine().Split(' ');
            int m = int.Parse(auxiliar[0]);
            int n = int.Parse(auxiliar[1]);
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                auxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(auxiliar[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}