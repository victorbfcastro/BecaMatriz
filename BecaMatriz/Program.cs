using System;

namespace BecaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            SomaDiagonal_Victor(matriz);
        }

        private static void ImprimeMatriz(int[,] matriz)
        {
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.Write($"{matriz[i, j]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        private static void SomaDiagonal_Victor(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)     //Preenche a lista com dados do usuario
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] matrizPronta = matriz;

            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            ImprimeMatriz(matrizPronta);

            Console.WriteLine($"\nSoma da Diagonal: {soma}");
            Console.Read();
        }
    }

}
