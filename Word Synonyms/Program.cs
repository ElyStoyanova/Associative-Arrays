using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
           // Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            var words = new Dictionary<string, List<string>>();
            int numberOfWords = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word,new List<string>()); //инициализираме нов списък
                }
                words[word].Add(synonym);
            }

            foreach (var item in words)
            {
                List<string> synonyms = item.Value;
                Console.WriteLine($"{item.Key} - {string.Join(", ",synonyms)}");
            }
        }
    }
}
