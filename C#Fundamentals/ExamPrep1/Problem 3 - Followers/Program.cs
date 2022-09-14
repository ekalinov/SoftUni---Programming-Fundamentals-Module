using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Followers
{
    internal class Program
    {
        static void Main(string[] args)
        {
     //    "Log out"
                        //o   "New follower: {username}"
                        //o   "Like: {username}: {count}"
                        //o   "Comment: {username}"
                        //o   "Blocked: {username}"

            string input;

            Dictionary<string,List<int>> followers = new Dictionary<string,List<int>>();

            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] commandArgs = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string username = commandArgs[1];

                   
                switch (command)
                {
                    case "New follower":
                        NewFollower(username, followers);
                        break;
                    case "Like":
                        int likesCount = int.Parse(commandArgs[2]);
                        Like(username, likesCount, followers);
                        break;
                    case "Comment":
                        Comment(username, followers);
                        break;
                    case "Blocked":
                        Block(username, followers);
                        break;
                }
            }


            Console.WriteLine($"{followers.Count} followers");
            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: { follower.Value.Sum()}");
            }

            if (followers.)
            {

            }
        }

        private static void NewFollower(string username, Dictionary<string, List<int>> followers)
        {
            if (!followers.ContainsKey(username))
            {
                followers.Add(username, new List<int>());
                followers[username].Add(0);
            }
            else return;
        }

        private static void Like(string username, int likesCount, Dictionary<string, List<int>> followers)
        {
            if (!followers.ContainsKey(username))
            {
                followers.Add(username, new List<int>());
                followers[username].Add(likesCount);
            }
            else
            {
                followers[username].Add(likesCount);
            }
        }

        private static void Comment(string username, Dictionary<string, List<int>> followers)
        {
            if (!followers.ContainsKey(username))
            {
                followers.Add(username, new List<int>());
                followers[username].Add(1);
            }
            else
            {
                followers[username].Add(1);
            }
        }

        private static void Block(string username, Dictionary<string, List<int>> followers)
        {

            if (followers.ContainsKey(username))
            {
                followers.Remove(username);
                
            }
            else
            {
                Console.WriteLine($"{username} doesn't exist.");
            }
        }
    }
}
