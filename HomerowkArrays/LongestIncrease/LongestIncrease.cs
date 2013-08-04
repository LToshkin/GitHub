// 04. Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;

namespace LongestIncrease
{
    class LongestIncrease
    {
        static void Main()
        {
            Console.Write("Array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            
            for (int i = 0; i < array.Length; i++)
			{
			    Console.Write("Element {0} = ", i);
                array[i] = int.Parse(Console.ReadLine());
			}

            int maxSequence = 0;
            int sequence = 1;
            string sequenceNumbers = "";
            string maxSequenceNumbers = "";
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    sequence++;
                    sequenceNumbers += array[i] + " ";
                }
                else
                {
                    if (maxSequence < sequence)
                    {
                        maxSequence = sequence;
                        sequenceNumbers += array[i] + " ";
                        maxSequenceNumbers = sequenceNumbers;
                    }
                    sequence = 1;
                    sequenceNumbers = "";
                }
            }

            if (maxSequence < sequence)
            {
                sequenceNumbers += array[array.Length - 1];
                maxSequenceNumbers = sequenceNumbers;
            }

            Console.WriteLine(maxSequenceNumbers);
        }
    }
}