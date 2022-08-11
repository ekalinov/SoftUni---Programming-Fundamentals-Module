using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            char[] charNumber = bigNumber.ToCharArray();
            Array.Reverse(charNumber);

            StringBuilder sb = new StringBuilder();

            int additionNumber = 0;
            if (number != 0)
            {
                foreach (char item in charNumber)
                {

                    int currNum = int.Parse(item.ToString()) * number + additionNumber; //9*2=18
                    int numToAdd = currNum % 10;

                    if (currNum / 10 > 0) //ostatyk 1 
                    {
                        additionNumber = currNum / 10;
                    }
                    else
                    {
                        additionNumber = 0;
                    }

                    sb.Append(numToAdd);

                }
            }
            else
            {
                Console.WriteLine("0");
            }

            if (additionNumber != 0)
            {
                sb.Append(additionNumber);

            }

           

            char[] bigString = sb.ToString().ToCharArray();
            Array.Reverse(bigString);


            Console.WriteLine(bigString);
        }
    }
}
