using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string,int>  allParticipants =  new Dictionary<string,int>();

            foreach (string participant in participants)
            {
                allParticipants[participant] = 0;

            }


            string participantsInfo;
            while ((participantsInfo=Console.ReadLine()) != "end of race")
            {

                StringBuilder sb  = new StringBuilder();

                int distance = 0;

                foreach  (char currChar in participantsInfo)
                {
                    if (char.IsLetter(currChar))
                    {
                       sb.Append(currChar);
                    }
                    else if (char.IsDigit(currChar))
                    {
                        distance += int.Parse(currChar.ToString());
                    }
                }

                string name = sb.ToString();

                if (allParticipants.ContainsKey(name))
                {
                    allParticipants[name]+=distance;
                }
               
            }


            Dictionary<string, int> sortedDict = allParticipants.OrderByDescending(x => x.Value).ToDictionary(t => t.Key, t => t.Value);
            List<string> topParticipants = sortedDict.Keys.ToList();





                Console.WriteLine($"1st place: {topParticipants[0]}");
                Console.WriteLine($"2nd place: {topParticipants[1]}");
                Console.WriteLine($"3rd place: {topParticipants[2]}");

            
                

        }
    }
}
