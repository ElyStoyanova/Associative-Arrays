using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingList = new Dictionary<String,String>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokans = Console.ReadLine().Split();
                string command = tokans[0];
                string username = tokans[1];
               

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = tokans[2];
                        if (!parkingList.ContainsKey(username))
                        {
                            parkingList.Add(tokans[1], tokans[2]);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        } 
                        break;
                    case "unregister":
                        if (!parkingList.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            parkingList.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                         break;
                }
            }
            foreach (var list in parkingList)
            {
                Console.WriteLine($"{list.Key} => {list.Value}");
            }
        }
    }
}
