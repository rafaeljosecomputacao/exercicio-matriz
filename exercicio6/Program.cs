using System;
using System.Globalization;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] matriz = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] auxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = double.Parse(auxiliar[j], CultureInfo.InvariantCulture);
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > 0.0)
                    {
                        soma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = linha; i <= linha; i++)
            {    
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = coluna; j <= coluna; j++)
                {
                    Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");          
            }
            Console.WriteLine();

            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0.0)
                    {
                        matriz[i, j] = Math.Abs(Math.Pow(matriz[i, j], 2.0));
                    }
                    Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}