using System.Text.RegularExpressions;

namespace _02._01.FancyBarcodes
{
    internal class Program
    {
/*
3
@#FreshFisH@#
@###Brea0D@###
@##Che4s6E@##
*/
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            string pattern = @"@#+(?<barcode>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})@#+";

            RegexOptions options = RegexOptions.Multiline;


            for (int i = 0; i < count; i++)
            {
                string line = Console.ReadLine();

                GroupCollection groupCollection = Regex.Match(line, pattern, options).Groups;


                if (groupCollection.Count == 1)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string barcode = groupCollection["barcode"].Value;
                string barcodeDigits = string.Empty;

                for (int index = 0; index < barcode.Length; index++)
                {
                    if (char.IsDigit(barcode[index]))
                    {
                        barcodeDigits += barcode[index];
                    }
                }
                if (barcodeDigits.Length == 0)
                {
                    Console.WriteLine("Product group : 00");
                }
                else 
                {
                    Console.WriteLine($"Product group: {barcodeDigits}");
                }
               
            }
        }
    }
}


