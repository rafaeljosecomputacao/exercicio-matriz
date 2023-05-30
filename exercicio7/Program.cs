using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] auxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(auxiliar[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());

            fila = fila - 1;
            int ultimoDaFila = matriz[fila, n - 1];
            for (int j = n - 1; j > 0; j--)
            {
                matriz[fila, j] = matriz[fila, j - 1];
            }
            matriz[fila, 0] = ultimoDaFila;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}