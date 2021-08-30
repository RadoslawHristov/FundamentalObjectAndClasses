using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsClass
{
    class Program
    {
        class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }
        static void Main(string[] args)
        {
            int numOfSong = int.Parse(Console.ReadLine());
            List<Song> songss = new List<Song>();

            for (int i = 0; i < numOfSong; i++)
            {
                string[] plylist = Console.ReadLine().Split('_');

                string type = plylist[0];
                string name = plylist[1];
                string timesSong = plylist[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = timesSong;

                songss.Add(song);
            }

            string typeList = Console.ReadLine();
            List<Song> filteredSong = songss.Where(s => s.TypeList == typeList).ToList();

            if (typeList=="all")
            {
                foreach (Song song in songss)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songss)
                {
                    if (song.TypeList==typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}