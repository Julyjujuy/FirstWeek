using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Floor Width");
            string userInputWidth = Console.ReadLine();
            int NewUserInputWidth = Convert.ToInt32(userInputWidth);

            Console.WriteLine("Enter Floor Lenght");
            string userInputLenght = Console.ReadLine();
            int NewUserInputLenght = Convert.ToInt32(userInputLenght);

            Console.WriteLine("Enter Cost per Unit");
            string userInputCost = Console.ReadLine();
            int NewUserInputCost = Convert.ToInt32(userInputCost);

            int squareMeters = NewUserInputWidth * NewUserInputLenght;
            int CostOfFlooring = squareMeters * NewUserInputCost;

            Console.WriteLine(CostOfFlooring);
            Console.ReadLine();

        }
    }
}
