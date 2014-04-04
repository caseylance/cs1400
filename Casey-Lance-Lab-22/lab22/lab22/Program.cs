using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an amount of money in dollars and cents:");
            double userInput = double.Parse(Console.ReadLine());
            int dollars = 0;
            int cents = 0;
            Console.WriteLine("You have {0} dollars and {1} cents.", dollars, cents);
            Console.ReadLine();
            
        }
    }
}
