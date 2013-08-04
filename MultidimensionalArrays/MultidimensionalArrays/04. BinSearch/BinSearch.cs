﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearch
{
    class BinSearch
    {
        static void Main()
        {

            Console.Write("Type K: ");
            int k = int.Parse(Console.ReadLine());
            
            Console.WriteLine("How big do you want your array to be? Type the length:");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine();

            Console.WriteLine("Enter the members of the array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Array.Sort(array);

            int temp = Array.BinarySearch(array, k);
            if (temp < 0)
            {
                Console.WriteLine(array[array.Length - 1]);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(array[temp]);
            }
           

            
        }

    }
}
