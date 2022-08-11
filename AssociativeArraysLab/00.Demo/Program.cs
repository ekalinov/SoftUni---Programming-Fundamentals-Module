using System;
using System.Collections.Generic;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string,string> phoneBook = new Dictionary<string,string>();

            phoneBook.Add("Tomy","08635+589");
            phoneBook.Add("Emo","08s89");
            phoneBook.Add("Gosho","08sssf+589");
            phoneBook.Add("Kolio","08qqqqq+589");
            phoneBook.Add("Filko","08635+589");

            Console.WriteLine(string.Join(", \n", phoneBook));

            SortedDictionary<string, string> sortedPhoneBook = new SortedDictionary<string, string>();

            sortedPhoneBook.Add("Tomy1", "08635+589");
            sortedPhoneBook.Add("Emo1", "08s89");
            sortedPhoneBook.Add("Gosho1", "08sssf+589");
            sortedPhoneBook.Add("Kolio1", "08qqqqq+589");
            sortedPhoneBook.Add("Filko1", "08635+589");

            Console.WriteLine(string.Join(", \n", sortedPhoneBook));
        }
    }
}
