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
            int globalArea = 0;
            while (true)
            { 
                Console.WriteLine("Enter Floor Width");
                string userInputWidth = Console.ReadLine();
                int NewUserInputWidth = Convert.ToInt32(userInputWidth);

                Console.WriteLine("Enter Floor Lenght");
                string userInputLenght = Console.ReadLine();
                int NewUserInputLenght = Convert.ToInt32(userInputLenght);
                int squareMeters = NewUserInputWidth * NewUserInputLenght;

                globalArea += squareMeters;
                Console.WriteLine("Is there any more Area to cover? 'Yes' to add");
                string answer = Console.ReadLine();
                if (answer != "Yes")
                {
                    break;
                }
            }

            decimal costPerSqmt = 86.00m / 20.00m;
            decimal CostOfFlooring = globalArea * costPerSqmt;


            //Console.WriteLine("Enter Cost per Unit");
            //string userInputCost = Console.ReadLine();
            //int NewUserInputCost = Convert.ToInt32(userInputCost);

            //int CostOfFlooring = globalArea * NewUserInputCost;



            Console.WriteLine(CostOfFlooring);
            Console.ReadLine();

        }
    }
}
