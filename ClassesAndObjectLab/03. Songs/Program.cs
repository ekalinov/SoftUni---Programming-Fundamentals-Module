using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                string typelist = tokens[0];
                string name = tokens[1];
                string time = tokens[2];


                Song newSong = new Song()
                {
                    Name = name,
                    TypeList = typelist,

                    Time = time
                };

                songs.Add(newSong);

            }

            string typeList = Console.ReadLine();


            if (typeList=="all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);

                    }
                }
            }

        }
    }
    class Song
    {
        public string Name { get; set; }

        public string TypeList { get; set; }

        public string Time { get; set; }

    }



}

