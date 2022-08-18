using System;
using System.Collections.Generic;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var ranking = new Dictionary<List<string>,Dictionary<string,int>>();
            var contestpassword =new List<string>();
            var nameAndGrade=new Dictionary<string, int>();

            while (input!="end of contests")
            {
                string[] tokans = input.Split(":");
                string contest = tokans[0]; contestpassword.Add(contest);
                string password = tokans[1]; contestpassword.Add(password);
                ranking.Add(contestpassword,nameAndGrade);

                input = Console.ReadLine();
            }
            while (input != "end of submissions")
            {
                string[] tokans = input.Split("=>");
                string contest = tokans[0];
                string password = tokans[1];
                string name = tokans[2];
                int poits = int.Parse(tokans[3]);

               // if (ranking.
               // {

            }
            //
                input = Console.ReadLine();
        }

        
    }
}
