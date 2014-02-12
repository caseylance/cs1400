//Casey Lance
//CS 1400
//Lab 10
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

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {    //state the purpose of the program
             Console.WriteLine("This program will return the value of the hypotenuse of a triangle.");
             Console.WriteLine();
            //Ask the user to enter the length of one side of a triangle.
            Console.WriteLine("Enter the value of the first side:");
            //Get the user's input and saves it in an appropriate variable.
            double sideA = double.Parse(Console.ReadLine());
            //Ask the user to enter the length of the other side of the triangle.
            Console.WriteLine("Enter the value of the other side:");
            //Get the user's input and saves it in an appropriate variable.
            double sideB = double.Parse(Console.ReadLine());
            //Call your CalcHypotenuse method and pass in the lengths of the two sides of the triangle as parameters.
            double result = CalcHypotenuse(sideA, sideB);
            //Save the value returned by the method in an appropriate variable.
            //Properly label and display the value returned by the method.
            Console.WriteLine();
            Console.WriteLine("The hypotenuse is {0:f2}.", result);
            Console.ReadLine();
        }
        // The CalcHypotenuse Method
        // Purpose: Calculates the hypotenuse of a triangle
        // Parameters: The value of side a and side b of the triangle as doubles
        // Returns: The hypotenuse of the triangle as a double.

        static double CalcHypotenuse(double side1, double side2)
        {
            //square each side
            //total the squares of the sides
            double totalSidesSquared = (side1 * side1) + (side2 * side2);
            //get square root of total, return as value
            double hypotenuse = Math.Sqrt(totalSidesSquared);
            return hypotenuse;
        }
    }
}
