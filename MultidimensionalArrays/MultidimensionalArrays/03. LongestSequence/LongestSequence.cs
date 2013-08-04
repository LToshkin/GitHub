using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequencesInThematrix
{

    static void Main(string[] args)
    {
       

        Console.WriteLine("Enter M: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter M: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        int sumOfWidth = 0;
        int width = 1;

        string widthElementMax = "";

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    width++;
                    if (sumOfWidth < width)
                    {
                        sumOfWidth = width;
                        widthElementMax = matrix[i, j];
                    }
                }
                else
                {
                    width = 1;
                }
            }
            width = 1;
        }

        int height = 1;
        int heightMax = 0;
        string heightElement = "";

        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (matrix[i, j] == matrix[i + 1, j])
                {
                    height++;
                    if (heightMax < height)
                    {
                        heightMax = height;
                        heightElement = matrix[i, j];
                    }
                }
                else
                {
                    height = 1;
                }
            }
            height = 1;
        }

        int right = 1;
        int rightMax = 0;
        string rightElement = "";

        for (int i = 0, j = 0; i < n - 1 && j < m - 1; i++, j++)
        {
            if (j >= m - 1 || i >= n - 1)
            {
                break;
            }
            else
            {
                if (matrix[i, j] == matrix[i + 1, j + 1])
                {
                    right++;
                    if (right > rightMax)
                    {
                        rightElement = matrix[i, j];
                        rightMax = right;
                    }
                    else right = 1;
                }
            }
        }

        int left = 1;
        int leftMax = 0;
        string Elementleft = "";

        for (int i = 0, j = m - 1; i < n - 1 && j >= 0; i++, j--)
        {
            if (j <= 0 || i >= n - 1)
            {
                break;
            }
            else
            {
                if (matrix[i, j] == matrix[i + 1, j - 1])
                {
                    left++;
                    if (left > leftMax)
                    {
                        Elementleft = matrix[i, j];
                        leftMax = left;
                    }
                    else left = 1;
                }
            }
        }

        int[] array = new int[4];

        array[0] = sumOfWidth;
        array[1] = heightMax;
        array[2] = rightMax;
        array[3] = leftMax;

        Array.Sort(array);

        if (array[3] == sumOfWidth)
        {
            for (int i = 0; i < sumOfWidth; i++) Console.Write(widthElementMax + " ");
            Console.WriteLine();
        }
        else if (array[3] == heightMax)
        {
            for (int i = 0; i < heightMax; i++) Console.Write(heightElement + " ");
            Console.WriteLine();
        }
        else if (array[3] == rightMax)
        {
            for (int i = 0; i < rightMax; i++) Console.Write(rightElement + " ");
            Console.WriteLine();
        }
        else if (array[3] == leftMax)
        {
            for (int i = 0; i < leftMax; i++) Console.Write(Elementleft + " ");
            Console.WriteLine();
        }
    }
}