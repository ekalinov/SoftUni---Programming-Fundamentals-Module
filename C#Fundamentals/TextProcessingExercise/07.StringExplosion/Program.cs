﻿using System;
using System.Linq;
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();



            StringBuilder sb = new StringBuilder();

                int explosionStrenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
               

                if (input[i] == '>')

                {
                    explosionStrenght += int.Parse(input[i + 1].ToString());
                    sb.Append(input[i]);
                }
                else if (explosionStrenght == 0)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    explosionStrenght--;
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
