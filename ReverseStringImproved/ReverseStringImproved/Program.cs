using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringImproved
{
    internal class Program
    {
        static void Main(string[] stringInput)
        {
            string Str, Revstr = ""; 
            

            int Length; 
            

            Console.Write("Please Enter A String: "); 
            

            Str = Console.ReadLine(); 
            

            Length = Str.Length - 1; 
            

            while (Length >= 0)  
                
            {
                Revstr = Revstr + Str[Length];  
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", Revstr); 
           
            Console.ReadLine();  
           

        }
    }
}
