//Casey Lance
//CS 1400
//Lab #16

//I declare that the following source code was written by me, or provided
//by the instructor for this project. I understand that copying 
//source code from any other source constitutes cheating, and that I will
//receive a zero grade on this project if I am found in violation of
// this policy.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some constants for saturday and sunday
            const string SAT = "Saturday";
            const string SUN = "Sunday";

            // declare a variable to hold user's input
            string today;

            // prompt the user to enter a day and get the input
            Console.Write("Please enter a day of the week, e.g. Tuesday: ");
            today = Console.ReadLine();

            

            // see if it is a work day and above freezing
            if ((today != SUN && today != SAT))
            {
                // prompt the user to enter a day and get the input
                Console.Write("Please enter the temperature in degrees farenheit: ");
                double temperature = double.Parse(Console.ReadLine());
                
                if (temperature > 32)
                {   // it is a workday and above freezing, display the go to work message
                    Console.WriteLine("You have to go to work today...");
                }
                else
                {
                    // it is a workday and below, display the go to work and dress warmly message
                    Console.WriteLine("Go to work, and dress warmly...");
                }
            }
            else
            {
                // its not a workday, display the weekend message
                Console.WriteLine("Yeah!  No work today!");
            }

            Console.ReadLine();
        }
    }
}
