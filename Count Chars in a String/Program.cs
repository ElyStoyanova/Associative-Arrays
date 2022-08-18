using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfChars = new Dictionary<char, int>();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]!=' ')
                {
                    if (!countOfChars.ContainsKey(text[i]))
                    {
                        countOfChars.Add(text[i], 0);
                    }
                    countOfChars[text[i]]++;
                }
            }
            foreach (var item in countOfChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
