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

        static void Checknumber(int guess, int randomnumber)
        {
            if (guess < randomnumber)
            {
                Console.WriteLine("You are too low");
            }
            if (guess > randomnumber)
            {
                Console.WriteLine("You are too high");

            }
            if (guess == randomnumber)
            {
                Console.WriteLine("You win!");

            }
        }
        static void Main(string[] args)
        {
            //Print Small Introduction with Rules
            Console.WriteLine("");

            //Generate a random number
            var randomnumber = Generatenumber(1, 100);            

            //Ask user to guess the number
            Console.WriteLine("Please Guess the Number I thought");

            string userInput = Console.ReadLine();
            int guess = Convert.ToInt32(userInput);
            //Check user input
           Checknumber(guess, randomnumber);
            //display Answer

            //End loop if user Wins
            Console.ReadLine(); 


        }
    }
}
