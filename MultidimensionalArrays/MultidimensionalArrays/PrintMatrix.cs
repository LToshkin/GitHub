// 01. Write a program that fills and prints a matrix of size (n, n) 

using System;

namespace PrintMatrix
{
    class PrintMatrix
    {
        static void Main()
        {
            Console.Write("Enter the size: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int num = 1;

            Console.WriteLine();
            Console.WriteLine("Matrix a) ");
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = num;
                    num++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            num = 1;
            Console.WriteLine("Matrix b) ");
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = num;
                        num++;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            num = 1;
            Console.WriteLine();
            Console.WriteLine("Matrix c) ");
            for (int row = 0; row <= n - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrix[n - row + col - 1, col] = num;
                    num++;
                }
            }

            for (int row = n - 2; row >= 0; row--)
            {
                for (int col = row; col >= 0; col--)
                {
                    matrix[row - col, n - col - 1] = num;
                    num++;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
