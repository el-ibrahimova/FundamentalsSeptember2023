using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string barcodePattern = @"@#+[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}@#+";


            for (int i = 0; i < count; i++)
            {
                string currentBarcode = Console.ReadLine();

                if (Regex.IsMatch(currentBarcode, barcodePattern))
                {
                    // @###Brea0D@### => B r e a 0 D => 0
                    // @##Che4s6E@##  => C h e 4 s 6 E => 4 6
                    // @#FreshFisH@# => F r e s h F i s h => digits.Length = 0

                    char[] digits = currentBarcode.Where(char.IsDigit).ToArray();
                    // digits => [4, 6]

                    string barcodeGroup = digits.Length == 0 ? "00" : string.Join("", digits);
                    // ? => означава възможните изходи - или "00", или лист от стойности
                    // => [4,6] => 46

                    Console.WriteLine($"Product group: {barcodeGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

