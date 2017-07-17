using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kill_Nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Define a List, named goodSongs, that will hold tuples consisting of two strings.

 Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:

 The name of an artist
 A song by that artist
 // Example
 HashSet<(string, string)> songs = new HashSet<(string, string)>();
 Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.

 Once the set is populated with 7 tuples, iterate(for loop) over the set of songs, and check if the band name is "Nickelback".

 If the band is not Nickelback, then add it to the goodSongs list.

 USe another foreach loop to print out all the good songs.
             */

            List<Tuple<string, string>> goodSongs = new List<Tuple<string, string>>();
            HashSet<Tuple<string, string>> allSongs = new HashSet<Tuple<string, string>>();
            allSongs.Add(Tuple.Create("Nickleback", "Photograph"));
            allSongs.Add(Tuple.Create("Ed Sheeran", "Shape of You"));

            allSongs.Add(Tuple.Create("Nickleback", "How You Remind Me"));

            allSongs.Add(Tuple.Create("Adam Levine", "Lost Stars"));

            allSongs.Add(Tuple.Create("Nickleback", "Burn It to the Ground"));

            allSongs.Add(Tuple.Create("Justin Bieber", "Despacito"));

            allSongs.Add(Tuple.Create("Nickleback", "Rockstar"));

           foreach (Tuple<string, string> song in allSongs)
            {
                if(song.Item1 != "Nickleback")
                {
                    goodSongs.Add((song));


                }

            }

           foreach(Tuple<string, string> goodsong in goodSongs)
            {
                Console.WriteLine($"{goodsong.Item1}" + " - " + $"{goodsong.Item2}");
            }
            Console.ReadKey();
        }
    }
}
