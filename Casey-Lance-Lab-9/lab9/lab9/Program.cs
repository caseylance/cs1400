//Casey Lance
//CS 1400
//Lab #9
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

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Tell user that program will determine the area for the unirrigated portion in the center of the field.
            Console.WriteLine("This program will calculate the area of the unirrigated portion at");
            Console.WriteLine("the center of the field.");
            Console.WriteLine("");

             //2.  Ask the use for the radius of the irrigated circle.
            Console.WriteLine("Please enter the radius of one of the irrigated circles in meters.");
            Console.WriteLine("");

            //3.  Get radius from user, convert from string, and store value.
            double radius = double.Parse(Console.ReadLine());

            //4.  Calculate and store the value of the area of the cirlce
            double circleArea = Math.PI * (radius * radius);
            
	        //5.  Calulate and store the value of the area of the square formed by the radii of the four circles.
            const double TWO = 2;
            double squareArea = (TWO * radius) * (TWO * radius);

            //6.  Store the difference between the value of the area of the square and the value of the area of the circle.
            double unirrigatedArea = squareArea - circleArea;
            
            //7.  Display value from #6 to the user.
            Console.WriteLine("");
            Console.WriteLine("The area of the unirrigated portion is {0:f2} square meters.", unirrigatedArea);
            
            
	        //8.  Keep window open until user hits enter.
            Console.WriteLine("");
            Console.WriteLine("Please press Enter to exit. ");
            Console.ReadLine();


        }
    }
}
