using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfResources = new Dictionary<string, int>();
            string inputCommand = Console.ReadLine();

            while (inputCommand!="stop")
            {
                string resource = inputCommand;
                int quontity =int.Parse( Console.ReadLine());
                if (!listOfResources.ContainsKey(resource))
                {
                    listOfResources.Add(resource, quontity);
                }
                else
                {
                    listOfResources[resource] += quontity;
                }
         
                inputCommand = Console.ReadLine();
            }
            foreach (var item in listOfResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
           
        }
    }
}
