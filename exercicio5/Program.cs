﻿using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] auxiliar = Console.ReadLine().Split(' ');
            int m = int.Parse(auxiliar[0]);
            int n = int.Parse(auxiliar[1]);
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            int[,] c = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                auxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(auxiliar[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                auxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(auxiliar[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}