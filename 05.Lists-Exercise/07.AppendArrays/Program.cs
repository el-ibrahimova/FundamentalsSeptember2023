namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            // [ 7 | 4 5 |1 0 || 2 5 |3]
            // [7] [4 5] [1 0] [ ] [2 5] [3]
            // - ако не използваме RemoveEmptyEntries нашия масив ще има този вид - с празни масиви = това е грешно

            List<string> symbols = ExtractSymbols(stringArrays);

            Console.WriteLine(string.Join(" ", symbols));

        }

        static List<string> ExtractSymbols(string[] stringArrays)
        {
            List<string> result = new List<string>();

            foreach (string sequence in stringArrays)
            {
                string[] array = sequence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(array);
            }
                return result;
        }
    }
}