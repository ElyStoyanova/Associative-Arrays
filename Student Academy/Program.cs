using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentAndGrades = new Dictionary<string, List<double>>();
            int pairOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < pairOfRows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
               
                if (!studentAndGrades.ContainsKey(name))
                {
                    studentAndGrades.Add(name, new List<double>());
                    studentAndGrades[name].Add(grade);
                }
                else
                {
                    studentAndGrades[name].Add(grade);

                }
            }
            foreach (var student in studentAndGrades.Where(s=>s.Value.Average()>=4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }


        }
    }
}
