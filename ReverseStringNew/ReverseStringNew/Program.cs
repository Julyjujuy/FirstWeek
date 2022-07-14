using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Str, Reversestr = "";
            // storing string value

            int Length;
            //count lenght of string

            Console.Write("Please Enter A String : ");
            //show message 

            Str = Console.ReadLine();
            // allow user to input string

            Length = Str.Length - 1;
            //storing the length of given string

            while (Length >= 0)
            //loops the given string length
            {
                Reversestr = Reversestr + Str[Length];
                //performimg a reverse string according to length of given string
                Length--;
            }
            Console.WriteLine("Reverse  String  Is:  {0}", Reversestr); // displaying output to user
            Console.ReadLine();

        }
    }
}
