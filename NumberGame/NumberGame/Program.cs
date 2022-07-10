using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{

    internal class Program
    {
        static int Generatenumber(int min, int max)
        {
            var rand = new Random();
            var number = rand.Next(min, max);
            Console.WriteLine(number);
            return number;

        }

        static void Main(string[] args)
        {
            //Print Small Introduction with Rules
            Console.WriteLine("");

            //Generate a random number
            var randomnumber = Generatenumber(1, 100);            
            //startloop
            //Ask user to guess the number
            //Check user input
            //display Answer
            //End loop if user Wins
            Console.ReadLine(); 


        }
    }
}
