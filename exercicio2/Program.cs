using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] auxiliar = Console.ReadLine().Split(' ');
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(auxiliar[j]);
                    soma += matriz[i, j];
                }
                vetor[i] = soma;
            }

            for (int i = 0; i < n; i++)
            {               
                 Console.WriteLine(vetor[i]);
            }
        }
    }
}