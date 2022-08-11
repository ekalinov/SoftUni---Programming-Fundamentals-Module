using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{

    class Team
    {
        public Team()
        {
            teamMembers = new List<string>();
        }
        public Team(string creator, string teamName)
        {
            CreatorName = creator;
            TeamName = teamName;
            teamMembers = new List<string>();
        }
        public string CreatorName { get; set; }
        public string TeamName { get; set; }
        public List<string> teamMembers { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            int countOfTheTeams = int.Parse(Console.ReadLine());

            List<Team> allTeams = new List<Team>();

            for (int i = 0; i < countOfTheTeams; i++)
            {
                string[] inputNewTeam = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string creator = inputNewTeam[0];
                string teamName = inputNewTeam[1];

                Team currTeam = new Team(creator, teamName);
                currTeam.teamMembers = new List<string>();

                bool doesCreatorExist = DoesCreatrExist(creator, allTeams);
                bool doesTeamExist = DoesTeamExist(teamName, allTeams);

                if (doesCreatorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                else if (doesTeamExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                allTeams.Add(currTeam);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] userToJoin = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string user = userToJoin[0];
                string teamToJoin = userToJoin[1];

                bool doesTeamExist = DoesTeamExist(teamToJoin, allTeams);
                bool doesMemberExist = DoesMemberExist(user, allTeams);



                if (!doesTeamExist)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }
                else if (doesMemberExist && allTeams.Any(team => team.CreatorName == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                    input = Console.ReadLine();
                    continue;
                }
               else if (allTeams.Any(team => team.CreatorName == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                    input = Console.ReadLine();
                    continue;
                }

                Team searchedTeam = allTeams.FirstOrDefault(team => team.TeamName == teamToJoin);
                searchedTeam.teamMembers.Add(user);
                input = Console.ReadLine();
            }

            List<Team> teamsWithMembers = allTeams
                .Where(team => team.teamMembers.Count > 0)
                .OrderByDescending(team => team.teamMembers.Count)
                .ThenBy(team => team.TeamName)
                .ToList();
            List<Team> teamsToDisbound = allTeams
                .Where(team => team.teamMembers.Count == 0)
                .OrderBy(team => team.TeamName)
                .ToList();

            PrintValidTeams(teamsWithMembers);

            PrintInvalidTeams(teamsToDisbound);


        }

        static void PrintInvalidTeams(List<Team> invalidTeams)
        {
            Console.WriteLine("Teams to disband:");
            foreach (Team team in invalidTeams)
            {
                Console.WriteLine(team.TeamName);
            }

        }

        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.TeamName}");
                Console.WriteLine($"- {validTeam.CreatorName}");

                foreach (string currMember in validTeam.teamMembers.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currMember}");
                }

            }

        }

        private static bool DoesMemberExist(string user, List<Team> allTeams)
        {
            foreach (Team team in allTeams)
            {
                if (team.teamMembers.Contains(user))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool DoesTeamExist(string teamName, List<Team> allTeams)
        {
            foreach (Team team in allTeams)
            {
                if (teamName == team.TeamName)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool DoesCreatrExist(string creator, List<Team> allTeams)
        {
            foreach (Team team in allTeams)
            {
                if (creator == team.CreatorName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
