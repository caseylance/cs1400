// Name: Casey Lance
// CS 1400 - 601
//Lab 24
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
        const int ITEMS = 100;
        static void Main(string[] args)
        {

            int[] arrayForLab = new int[ITEMS];
            int indexArrayForLab = 0;
            int arrayItemElement = 0;
            int tempArrayElemntValue = 0;

            do
            {
                
                arrayItemElement++;
                Console.WriteLine("Enter the {0} element in the array, and zero to stop:", ToOrdinal(arrayItemElement));
                tempArrayElemntValue = int.Parse(Console.ReadLine());
                if (tempArrayElemntValue != 0)
                {
                    arrayForLab[indexArrayForLab++] = tempArrayElemntValue;
                }
            } while (tempArrayElemntValue != 0 && indexArrayForLab < ITEMS);

            Console.WriteLine("\nThe elements in the array are:");

            for (int i=0; i < indexArrayForLab; i++)
            {
                Console.Write("{0} ", arrayForLab[i]);
            }


            int valueProduct = ArrayProduct(arrayForLab, indexArrayForLab);
            Console.WriteLine("\n\nThe product of the elements in the array is:");
            Console.WriteLine("{0}", valueProduct);
            Console.ReadLine();

        }

        static int ArrayProduct (int[] arrayForLab, int size)
        {
            int arrayProduct =1;
            for(int i=0; i <size; i++)
            {
                arrayProduct *= arrayForLab[i];
            }
            return arrayProduct;
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
            else if (number >= 14)
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
