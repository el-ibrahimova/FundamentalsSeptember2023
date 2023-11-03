namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourceMap = new Dictionary<string, uint>();
            
            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                
                if (!resourceMap.ContainsKey(resource))
                {
                    resourceMap.Add(resource, 0);
                }
                var quantity = uint.Parse(Console.ReadLine());

                resourceMap[resource] += quantity;
            }

            foreach (KeyValuePair<string, uint> resourcePair in resourceMap)
            {
                Console.WriteLine($"{resourcePair.Key} -> {resourcePair.Value}");
            }
        }
    }
}