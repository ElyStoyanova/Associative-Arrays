using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> countOfNumbers = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (!countOfNumbers.ContainsKey(number))
                {
                    countOfNumbers.Add(number, 0);
                }
                countOfNumbers[number]++;
            }

            foreach (var item in countOfNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
