namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            int count = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int shoots = int.Parse(input);

                if (shoots >= 0 && shoots < targets.Count)
                {
                    count++;
                    int shootIndex = targets[shoots];

                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i] != -1)
                            {
                                if (targets[i] > shootIndex)
                                {
                                    targets[i] = targets[i] - shootIndex;
                                }
                                else if (targets[i] <= shootIndex)
                                {
                                    targets[i] = targets[i] + shootIndex;
                                }
                            }
                        }
                        targets[shoots] = -1;
                }
            } 

            Console.Write($"Shot targets: {count} -> ");
            for (int i = 0; i < targets.Count; i++)
            { 
                Console.Write($"{targets[i]} ");
            }
        }
    }
}