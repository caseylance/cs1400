//Casey Lance
//CS 1400
//Lab #3
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

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Hal.");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            Console.WriteLine();
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello {0}, how old are you?", userName);
            Console.WriteLine();
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("How much money do you have {0}?", userName);
            Console.WriteLine();
            double userMoneyAmount = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Thanks {0}!", userName);
            Console.Write(" You are {0} years old", userAge);
            Console.Write(" and have ${0}.  Wow!", userMoneyAmount);
            Console.ReadLine();
          }
    }
}
