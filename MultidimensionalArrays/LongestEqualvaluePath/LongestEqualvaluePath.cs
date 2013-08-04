// 07. * Write a program that finds the largest area of equal neighbor 
//       elements in a rectangular matrix and prints its size. 

using System;

class LongestEqualvaluesPath
{
    public static int maxPathLength = 0;
    public static int currentPathLength = 0;

    static void Main()
    {
        Console.Write("Input first matrix dimension: ");
        int aSize = int.Parse(Console.ReadLine());
        Console.Write("Input second matrix dimension: ");
        int bSize = int.Parse(Console.ReadLine());
        string[,] matrix = new string[aSize, bSize];
        for (int i = 0; i < aSize; i++)
        {
            Console.WriteLine("Input values of row {0}!", i);
            for (int j = 0; j < bSize; j++)
            {
                Console.Write("Value {0}: ", j);
                matrix[i, j] = Console.ReadLine();
            }
        }

        PrintMatrix(matrix);
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != "*")
                {
                    currentPathLength = 0;
                    SearchPath(matrix, i, j);
                    PrintMatrix(matrix);
                    Console.WriteLine("CurrentPathLength = {0}\n\n", currentPathLength);
                    if (currentPathLength > maxPathLength) maxPathLength = currentPathLength;
                }
            }
        }
        Console.WriteLine("MaxPathLength = {0}", maxPathLength);
    }

    public static void SearchPath(string[,] matrix, int i, int j)
    {
        string cellValue = matrix[i, j];
        matrix[i, j] = "*";
        currentPathLength++;
        for (int add = -1; add <= 1; add += 2)
        {
            if (IsValidCell(matrix, i + add, j) && matrix[i + add, j] == cellValue)
            {
                SearchPath(matrix, i + add, j);
            }
            if (IsValidCell(matrix, i, j + add) && matrix[i, j + add] == cellValue)
            {
                SearchPath(matrix, i, j + add);
            }
        }
    }

    public static void PrintMatrix(string[,] matrix)
    {
        int maxLength = 0;
        foreach (string element in matrix)
        {
            if (element.Length > maxLength) maxLength = element.Length;
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ",
                    matrix[i, j].PadLeft(matrix[i, j].Length + (maxLength - matrix[i, j].Length) / 2).PadRight(maxLength));
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }

    public static bool IsValidCell(string[,] matrix, int x, int y)
    {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
    }
}