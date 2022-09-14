using System;
using System.Linq;
using System.Text;

namespace _003.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "find")
            {
                StringBuilder sb = new StringBuilder();

                int keyIndex = 0;

                string message = input;
                for (int i = 0; i < message.Length; i++)
                {

                    int currCharNumber = message[i];
                    char newchar = (char)(currCharNumber - keys[keyIndex]);
                    keyIndex++;

                    sb.Append(newchar);

                    if (keyIndex == keys.Length)
                    {
                        keyIndex = 0;
                    }

                }

                string hiddenMessage = sb.ToString();
                if (hiddenMessage.Contains('&') &&
                    hiddenMessage.Contains('<') &&
                    hiddenMessage.Contains('>'))
                {

                    int startingIndexOfType = hiddenMessage.IndexOf("&")+1;
                    int typeLenght = hiddenMessage.LastIndexOf("&") - startingIndexOfType ;
                    int startingIndexOfCoordinates = hiddenMessage.IndexOf("<")+1;
                    int coordinatesLenght = hiddenMessage.IndexOf(">") - startingIndexOfCoordinates;


                    string type = hiddenMessage.Substring(startingIndexOfType, typeLenght);
                    string coordinates = hiddenMessage.Substring(startingIndexOfCoordinates, coordinatesLenght);

                    Console.WriteLine($"Found {type} at {coordinates}");

                }






                input = Console.ReadLine();
            }



        }
    }
}
