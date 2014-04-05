// Casey Lance
// CS 1400
// Lab 22
//---------------------------------------------------------------------
// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


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
            char userResponse = 'N';
            bool res;
            int dollars = 0;
            Int32 cents = 0;
            double userInput;
            
            do
            {
                do
                {
                    Console.WriteLine("Please enter an amount of money in dollars and cents:");
                    string userInputString = (Console.ReadLine());
                    res = double.TryParse(userInputString, out userInput);
                    if (res == false)
                    {
                        Console.WriteLine("You must enter a number.  Please try again.\n");
                    }
                    MoneyConversion(ref userInput, ref dollars, ref cents);
                } while (res == false);

                Console.WriteLine("\nYou have {0} dollars and {1} cents.", dollars, cents);
                Console.WriteLine("\nWould you like to go again?  Please enter Y or N");
                userResponse = Char.Parse(Console.ReadLine());
                userResponse = Char.ToUpper(userResponse);
                Console.WriteLine();
                while (userResponse !='Y' && userResponse != 'N')
                {
                    Console.WriteLine("You must enter either Y or N.  Please try again");
                    userResponse = char.Parse(Console.ReadLine());
                    userResponse = Char.ToUpper(userResponse);
                }
                
            } while (userResponse == 'Y');
            
            if (userResponse == 'N')
            {
                Console.WriteLine("\nGood Bye. Press Enter to exit");
                Console.ReadLine();

            }                           
        }

        static void MoneyConversion(ref double n1, ref int n2, ref Int32 n3)
        {
            const double CONSTANT = 100;
            double tempN3;
            n2 = (int)n1;
            tempN3 = (n1 - n2) * CONSTANT;
            
            Convert.ToInt32(tempN3);
            
            n3 = Convert.ToInt32(tempN3);
           
         
        }
    }

}
