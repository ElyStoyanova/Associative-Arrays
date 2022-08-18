using System;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyUsers = new Dictionary<string, List<string>>();
            string inputCommand = Console.ReadLine();

            while (inputCommand!="End")
            {
                string[] tokans = inputCommand.Split(" -> ");
                string companyName = tokans[0];
                string employees = tokans[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                    companyUsers[companyName].Add(employees);
                }
                else if (!companyUsers[companyName].Contains(employees))
                {
                    companyUsers[companyName].Add(employees);
                }
  
                inputCommand = Console.ReadLine();
            }
            foreach (var company in companyUsers)
            {
                Console.WriteLine($"{company.Key}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ",company.Value));
            }
        }
    }
}
