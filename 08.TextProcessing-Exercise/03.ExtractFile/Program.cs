namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // може да се реши и по този начин - с методите Get
            // string filePath = Console.ReadLine();
           // Console.WriteLine($"File name: {Path.GetFileNameWithoutExtension(filePath)}");
           //  Console.WriteLine($"File extension: {Path.GetExtension(filePath).Replace(".","")}"); // заменя точката с празен стринг


            string filePath = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int lastSeparatorIndex = filePath.LastIndexOf('\\'); // търсим последния индекс \ но трябва да изпишем \\

            int extensionIndex = filePath.LastIndexOf('.');

            if (lastSeparatorIndex != -1 &&
                extensionIndex != -1 &&
                extensionIndex > lastSeparatorIndex)
            {
                fileName = filePath.Substring(lastSeparatorIndex+1, extensionIndex - lastSeparatorIndex-1);

                fileExtension = filePath.Substring(extensionIndex+1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}