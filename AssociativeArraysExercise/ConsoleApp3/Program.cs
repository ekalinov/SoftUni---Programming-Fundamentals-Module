using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] keyTokens = new string[] {"shards","motes","fragments"};

            Dictionary<string, int> ResourseQuantitiPairs = new Dictionary<string, int>();
            ResourseQuantitiPairs["shards"] = 0;
            ResourseQuantitiPairs["motes"] = 0;
            ResourseQuantitiPairs["fragments"] = 0;

            Dictionary<string, int> JunkPairs = new Dictionary<string, int>();

            Dictionary<string, string> itemObtainedTokensPairs = new Dictionary<string, string>();
            itemObtainedTokensPairs["shards"] = "Shadowmourne";
            itemObtainedTokensPairs["motes"] = "Dragonwrath";
            itemObtainedTokensPairs["fragments"] = "Valanyr";
            


            bool isItemObtained = false;

            while (!isItemObtained)
            {
                //•	Each line comes in the following format:
                //"{quantity} {material} {quantity} {material} … {quantity} {material}"

                string input = Console.ReadLine().ToLower();

                string[] inputArray = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < inputArray.Length ; i+=2)
                {
                        string key = inputArray[i + 1];
                        int value = int.Parse(inputArray[i]);

                    if (keyTokens.Contains(key))
                    {
                    
                        if (ResourseQuantitiPairs.ContainsKey(key))
                        {
                            ResourseQuantitiPairs[key] += value;
                            if (ResourseQuantitiPairs[key]>=250)
                            {
                                isItemObtained = true;

                                ResourseQuantitiPairs[key] -= 250;

                                Console.WriteLine($"{itemObtainedTokensPairs[key]} obtained!");
                                break;
                            }
                        }
                       
                    }
                    else
                    {
                        if (JunkPairs.ContainsKey(key))
                        {
                            JunkPairs[key] += value;

                        }
                        else
                        {
                            JunkPairs.Add(key, value);
                        }
                    }


                }

            }

            foreach (var kvp in ResourseQuantitiPairs)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in JunkPairs)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }





        }
    }
}
