// 04. Write a program that finds the maximal sequence of equal elements in an array.


using System;
using System.Linq;

namespace LongestIncrease
{
    class EqualElements
    {
        static void Main()
        {
            Console.Write("Elements count: ");
            int n = int.Parse(Console.ReadLine());
            
            int frequentValue = 0, length = 0, longest = 0;
            int[] arr = new int[n];
            
            arr[0] = int.Parse(Console.ReadLine()); // Reads first element
            
            for (int i = 1; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); // Reads second to last elements
                if (arr[i - 1] == arr[i])
                {
                    length++;            // If previous index is equal to current index increase lenght
                    if (length > longest)
                    {
                        longest = length; // Set the maximal sequence of elements
                        frequentValue = arr[i]; // What is the value of the element which will be printed
                    }
                }
                else length = 1;    // Else start new checking        
            }
            for (int i = 0; i < longest; i++)
            {
                Console.Write("{0} ", frequentValue); // Print the element (longest) times
            }
        }
    }
}