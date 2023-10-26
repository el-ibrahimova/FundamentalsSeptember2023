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

            for (int i = 0; i <n ; i++)
            {
                string[] currentInput = Console.ReadLine().Split("_");

                string typeList = currentInput[0];
                string name = currentInput[1];
                string time = currentInput[2];

                Song song = new Song(typeList, name, time); // създаваме обекта 
                songs.Add(song);
            }
           
            string list = Console.ReadLine(); // "all" или TypeList - по условие
         
            for (int i = 0; i < songs.Count; i++)
            { 
                Song currentSong = (songs[i]);

                if (list == "all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (list == currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
                
               
                
                Console.WriteLine(currentSong.TypeList);

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
}
