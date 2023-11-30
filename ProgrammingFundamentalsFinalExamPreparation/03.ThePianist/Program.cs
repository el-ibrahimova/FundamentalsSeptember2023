namespace _03.ThePianist
{
    public class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
        public void Update(string newKey)
        {
            Key = newKey;
        }
        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split("|");
                string name = information[0];
                string composer = information[1];
                string key = information[2];

                Piece piece = new Piece(name, composer, key);
                if (!pieces.ContainsKey(name))
                {
                    pieces.Add(name, piece);
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split("|");
                string command = commands[0];
                string name = commands[1];

                if (command == "Add")
                {
                    string composer = commands[2];
                    string key = commands[3];

                    if (!pieces.ContainsKey(name))
                    {
                        Piece piece1 = new Piece(name, composer, key);
                        pieces.Add(name, piece1);
                        Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    if (pieces.ContainsKey(name))
                    {
                        pieces.Remove(name);
                        Console.WriteLine($"Successfully removed {name}!");
                    }
                    else 
                    {
                     Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                }
                else  // "ChangeKey"
                {
                    string newKey = commands[2];

                    if (pieces.ContainsKey(name))
                    {
                        pieces[name].Update(newKey);
                        Console.WriteLine($"Changed the key of {name} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                }
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine(piece.Value);
            }
        }
    }
}