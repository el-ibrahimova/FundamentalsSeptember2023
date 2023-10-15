namespace ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> list = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            
         
            List<string> command = Console.ReadLine().Split().ToList();
            string input = command[0];

            
            while (input != "end")
            {
                if (input == "swap")
                {
                    SwapElements(list, command);

                }
                else if (input == "multiply")
                {
                    MultiplyElements(list, command);

                }
                else if (input == "decrease")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = list[i] - 1;
                    }
                }

                command = Console.ReadLine().Split().ToList();
                input = command[0];
            }

            Console.WriteLine(string.Join(", ", list));
            

        }

       

        static void SwapElements(List<int> list, List<string> command)
        {
            string index1 = command[1];
            int index11 = int.Parse(index1);
            string index2 = command[2];
            int index22 = int.Parse(index2);

            list.Add(list[index11]);
            list.Insert(index11, list[index22]);
            list.RemoveAt(index11 + 1);
            list.Insert(index22, list[list.Count - 1]);
            list.RemoveAt(index22 + 1);
            list.RemoveAt(list.Count - 1);
        }

        static void MultiplyElements(List<int> list, List<string> command)
        {
            string index1 = command[1];
            int index11 = int.Parse(index1);
            string index2 = command[2];
            int index22 = int.Parse(index2);

            int result = list[index11] * list[index22];
            list.Insert(index11, result);
            list.RemoveAt(index11 + 1);
        }
    }
}