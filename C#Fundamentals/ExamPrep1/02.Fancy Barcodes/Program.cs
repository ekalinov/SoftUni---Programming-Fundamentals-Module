using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string validBarcodePattern = @"\@\#+(?<product>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})\@\#+";


            Regex regex = new Regex(validBarcodePattern);

            for (int i = 0; i < lines; i++)
            {
                string barcode = Console.ReadLine();    

                Match match = regex.Match(barcode);

                if (match.Success)
                {
                    string product = match.Groups["product"].Value;

                    StringBuilder sb = new StringBuilder();

                    foreach (char item in product)
                    {
                        if (char.IsDigit(item))
                        {
                            sb.Append(item);
                        }
                    }
                    string productGroup;
                    if (sb.ToString()!= "")
                    {
                         productGroup = sb.ToString();
                    }
                    else productGroup = "00";

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
