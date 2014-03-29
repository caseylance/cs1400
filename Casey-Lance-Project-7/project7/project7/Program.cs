//Casey Lance
//CS 1400
//Project #7
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

namespace project7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casey Lance \nCS 1400 \nProject 7\n\n");
            
            int months = 0;
            int totalAdultRabbits = 1;
            int babyRabbits = 0;
            int totalRabbits = 0;
            
            Console.WriteLine("Months \tAdults \tBabies \tTotal Rabbits");

            while (totalRabbits <= 500) 
            {
                months++;

                totalRabbits = totalAdultRabbits + babyRabbits;
                Console.WriteLine("{0}\t{1} \t{2} \t{3}", months, totalAdultRabbits, babyRabbits, totalRabbits);
                
                totalAdultRabbits += babyRabbits;
                babyRabbits = totalAdultRabbits - babyRabbits;
            }
            Console.WriteLine("\n \nThe scientist will run out of cages after {0} months.", months);
            Console.ReadLine();
        }
    }
}
