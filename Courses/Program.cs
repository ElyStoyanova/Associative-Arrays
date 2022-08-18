using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var courses = new Dictionary<string, List <string> >();
            string inputCommand = Console.ReadLine();
            

            while (inputCommand!="end")
            {
                string[] tokans = inputCommand.Split(" : ");
                string coursesName = tokans[0];
                string studentName = tokans[1];
                
                if (!courses.ContainsKey(coursesName))
                {
                    courses.Add(coursesName, new List<string>());
                    courses[coursesName].Add(studentName);
                }
                else
                {
                    courses[coursesName].Add(studentName);
                }
                inputCommand = Console.ReadLine();
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: { course.Value.Count}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ",course.Value));
            }
        }
    }
}
