using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var songs = new List<Songs>
            {
                new Songs(1, "uta", "imperial circus dead decadence", new DateTime(2020, 12, 05)),
                new Songs(2, "painters of the tempest", "ne obliviscaris", new DateTime(2022, 10, 19)),
                new Songs(3, "Equus", "Ne Obliviscaris", new DateTime(2024, 12, 12)),
                new Songs(4, "In Putris Stagnum", "Xanthochroid", new DateTime(2022, 10, 02))
            };

            Console.WriteLine("Musicas do ano 2024");
            var songs2024 = songs.Where(x => x.ReleaseDate.Year == 2024).ToList(); // LINQ

            foreach(var item in songs2024)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Musicas feitas em outubro");
            var songsOnOctober = songs.Where(x => x.ReleaseDate.Month == 10).ToList(); // LINQ

            foreach (var item in songsOnOctober)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Musicas em ordem alfabetica");
            var songsOrder = songs.OrderBy(x => x.Name);

            foreach (var item in songsOrder)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("as ultimas 2 musicas em ordem alfabeitca");
            var songsLast2 = songs.OrderBy(x => x.Name).Reverse().Take(2).Reverse().ToList(); // LINQ

            foreach (var item in songsLast2)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
