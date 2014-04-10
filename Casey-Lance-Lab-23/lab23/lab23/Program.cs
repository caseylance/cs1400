// Name: Casey Lance
// CS 1400 - 601
//Lab 23
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

namespace lab23
{
    class Program
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            
            int[] arrayForLab = new int[SIZE];

            for (int i = 0; i < SIZE; i++)
            {   int value = i+1;
                Console.WriteLine("Enter the {0} value in the array:", ToOrdinal(value));
                int arrayValue = arrayForLab[i];
                arrayForLab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe values in the array are:");

            foreach (int value in arrayForLab)
            {
                Console.Write("{0} ", value);
            }
                
            
            int valueTotal = TotalArray(arrayForLab);
            Console.WriteLine("\n\nThe sum of the values in the array is:");
            Console.WriteLine("{0}", valueTotal);
            Console.ReadLine();
              
        }
        
        static int TotalArray (int[] arrayForLab)
        {
            int sumOfArrayValues=0;
            for (int i=0; i < arrayForLab.Length; i++)
            {
                sumOfArrayValues += arrayForLab[i]; 
            }
            return sumOfArrayValues;
        }

        static string ToOrdinal(int num)
        {
            int number = num;
            const int TEN = 10;
            string numString = number.ToString();
            string ordinal = "";
            if (number == 1)
            {
                ordinal = numString + "st";
            }
            else if (number == 2)
            {
                ordinal = numString + "nd";
            }
            else if (number == 3)
            {
                ordinal = numString + "rd";
            }
            else if (number > 3 && number <= 13)
            {
                ordinal = numString + "th";
            }
            else if (number >=14)
            {
                if (number % TEN == 0)
                {
                    ordinal = numString + "th";
                }
                else if (number % TEN == 1)
                {
                    ordinal = numString + "st";
                }
                else if (number % TEN == 2)
                {
                    ordinal = numString + "nd";
                }
                else if (number % TEN == 3)
                {
                    ordinal = numString + "rd";
                }
                else
                {
                    ordinal = numString + "th";
                }
 
            }

            return ordinal;
        }

            
        
    }
}
