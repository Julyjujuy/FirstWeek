using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read the string
            Console.WriteLine("Enter String to Reverse Please");
            string s = Console.ReadLine();
            //convert string to array
            char[] chars = s.ToCharArray();
            //Reverse Array
            Array.Reverse(chars);
            //Display Result
            Console.WriteLine(chars);
            //Pause
            Console.ReadLine();

        }
    }
}
