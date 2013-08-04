// 05. You are given an array of strings. Write a method that sorts the array 
//     by the length of its elements (the number of characters composing them).


using System;

namespace SortByLength
{
    class SortByLength
    {
        static void Main()
        {
            Console.WriteLine("How big do you want your array to be? Type the length:");
            int arrayLength = int.Parse(Console.ReadLine());

            string[] array = new string[arrayLength];

            Console.WriteLine();

            Console.WriteLine("Enter the members of the array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine();


            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine("Your sorted array looks like that: \n");


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}