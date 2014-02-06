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
	        Console.WriteLine("This program will calculate the area of the unirrigated portion at the center of the field.");
                          
             //2.  Ask the use for the radius of the irrigated circle.
            Console.WriteLine("Please enter the radius of the irrigated circle.");
            
            //3.  Get radius from user, convert from string, and store value.
            double radius = double.Parse(Console.ReadLine());

            //4.  Calculate and store the value of the area of the cirlce
            double circleArea = Math.PI * (radius * radius);
            
	        //5.  Calulate and store the value of the area of the square formed by the radii of the four circles.
            const double TWO = 2;
            double squareArea = (TWO * radius) * (2 * radius);

            //6.  Store the difference between the value of the area of the square and the value of the area of the circle.
            double unirrigatedArea = squareArea - circleArea;
            
            //7.  Display value from #6 to the user.
            Console.WriteLine("The are of the unirrigated portion is {0}", unirrigatedArea);

	        //8.  Keep window open until user hits enter.
            Console.ReadLine();


        }
    }
}
