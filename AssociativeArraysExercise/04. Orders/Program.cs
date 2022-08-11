using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, decimal> ProductListPrice  = new Dictionary<string, decimal>();
            Dictionary<string, int> ProductListQty  = new Dictionary<string, int>();

            string inputCmd = Console.ReadLine();

            while (inputCmd!= "buy")
            {
                string[] productArgs = inputCmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);


                string productName = productArgs[0];
                decimal productPrice = decimal.Parse(productArgs[1]);
                int productQty = int.Parse(productArgs[2]);

             
                if (!ProductListPrice.ContainsKey(productName))
                {
                    ProductListPrice.Add(productName, productPrice);
                    ProductListQty.Add(productName, productQty);    
                }
                else
                {
                    ProductListPrice.Remove(productName);
                    ProductListPrice.Add(productName, productPrice);
                    ProductListQty[productName] += productQty;
                }


                inputCmd = Console.ReadLine();
            }

            foreach (var kvp in ProductListPrice)
            {
                foreach (var item in ProductListQty)
                {
                    if (item.Key==kvp.Key)
                    {

                Console.WriteLine($"{kvp.Key} -> {kvp.Value*item.Value:f2}");
                    }
                }
            }


        }
    }
}
