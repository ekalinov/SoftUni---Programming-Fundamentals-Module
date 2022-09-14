using System;
using System.Linq;

namespace _00001._LAdybug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            string[] field = new string[sizeOfField];

            for (int i = 0; i < field.Length; i++)
            {
                field[i] = "0";
            }

            int[] startingIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (int index in startingIndexes)
            {
                if (index < 0 || index >= field.Length)
                {
                    continue;
                }
                field[index] = "1";
            }



            string flightArgs;

            while ((flightArgs = Console.ReadLine()) != "end")
            {
                string[] flightArgsArr = flightArgs.Split();

                int indexOfLadyBug = int.Parse(flightArgsArr[0]);
                string direction = flightArgsArr[1];
                int flightLenght = int.Parse(flightArgsArr[2]);

                if (indexOfLadyBug < 0 || indexOfLadyBug >= field.Length || field[indexOfLadyBug] == "0")
                {
                    continue;
                }


                field[indexOfLadyBug] = "0";
                if (direction == "right")
                {
                    bool flightEnd = false;
                    int newIndex = indexOfLadyBug + flightLenght;
                    while (!flightEnd)
                    {
                        if (newIndex < field.Length)
                        {
                            if (field[newIndex] != "1")
                            {
                                field[newIndex] = "1";
                                flightEnd = true;
                            }
                            else newIndex += flightLenght;

                        }
                        else flightEnd = true;
                    }
                }
                else if (direction == "left")
                {
                    bool flightEnd = false;
                    int newIndex = indexOfLadyBug - flightLenght;
                    while (!flightEnd)
                    {
                        if (newIndex >= 0)
                        {
                            if (field[newIndex] != "1")
                            {
                                field[newIndex] = "1";
                                flightEnd = true;
                            }
                            else newIndex -= flightLenght;

                        }
                        else flightEnd = true;
                    }
                }
            }



            Console.WriteLine(string.Join(" ", field));


        }
    }
}
