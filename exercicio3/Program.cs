using System;

namespace exercicio3
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
                int maior = 0;
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(auxiliar[j]);
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
                vetor[i] = maior;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}