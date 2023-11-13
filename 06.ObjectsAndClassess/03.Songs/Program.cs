using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // {Song("",name,1), Song("", name 1 ...)}

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] currentInput = Console.ReadLine().Split("_");

                string typeList = currentInput[0];
                string name = currentInput[1];
                string time = currentInput[2];

                Song song = new Song(typeList, name, time); // създаваме обекта 
                songs.Add(song);
            }

            string list = Console.ReadLine(); // "all" или TypeList - по условие


            if (list == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == list)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            // записване на output-a с LINQ
            //  if (list == "all")
            //  {
            //     var searchSongs = songs.Select(x => x.Name);
            //     Console.WriteLine(string.Join("", searchSongs));
            //  }
            //  else 
            // {
            //      var searchSongs = songs.Where(x=>x.TypeList == list).Select(x => x.Name);
            //      Console.WriteLine(string.Join("", searchSongs));
            // } 

        }
    }
}

public class Song
{
    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }

    public string TypeList { get; set; }

    public string Name { get; set; }
    public string Time { get; set; }
}

