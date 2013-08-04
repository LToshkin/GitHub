// 09. Write a program that finds the most frequent number in an array

// It won't say that two numbers are equally frequent if they are. I didn't know better way.

using System;

namespace MostFrequent
{
    class MostFrequent
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxCounter = 1;
            int mostFrequent = 0;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    mostFrequent = array[i];
                }
            }

            if (maxCounter > 1)
            {
                Console.WriteLine("Most frequent number = {0}", mostFrequent);
                Console.WriteLine("Count = {0} times", maxCounter);
            }
            else
            {
                Console.WriteLine("All elements are different");
            }
        }
    }
}
