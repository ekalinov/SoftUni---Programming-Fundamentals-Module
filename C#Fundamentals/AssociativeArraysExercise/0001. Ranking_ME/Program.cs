using System;
using System.Collections.Generic;

namespace _0001._Ranking_ME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ContestPasswordVP = new Dictionary<string, string>();
            Dictionary<string, List< string>> UserContestVP = new Dictionary<string, List<string>>();
            Dictionary<string, int> ContestPointsVP = new Dictionary<string, int>();




            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] contestInfo = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contestName = contestInfo[0];
                string contestPassword = contestInfo[1];

                if (!ContestPasswordVP.ContainsKey(contestName))
                {
                    ContestPasswordVP.Add(contestName, contestPassword);
                }
                    
                input = Console.ReadLine();
            }


            while (input != "end of submissions")
            {
                string[] userInfo = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = userInfo[0];
                string password = userInfo[1];
                string username = userInfo[2];
                int points = int.Parse(userInfo[3]);

                if (!ContestPasswordVP.ContainsKey(contest) && ContestPasswordVP[contest]== password)
                {
                    if (!UserContestVP.ContainsKey(username))
                    {
                        UserContestVP.Add(username, new List<string>());
                        UserContestVP[username].Add(contest);


                    }






                  
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }


        }
    }
}
