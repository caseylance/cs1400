// File Prologue
// Name: Casey Lance
// CS 1400-Section: 601
// Lab: 18
// Date: PUT TODAY"S DATE HERE
// 
// Sample Program To Illustrate Debugger
// Calculates the gross pay for a Sales
// If a person's sales exceed $40,000 in one month, then their commission will be ten percent 
// of their sales for that month. If their sales is less than $25,000 then their commission
// is three percent of their sales for the month. Otherwise, their commission will be five
// percent of their sales for the month. Their gross pay is equal to a base salary of
// $1,000 each month plus their commission.

using System;

class Program
{
    // declare constants - no magic numbers
    const int BIG = 40000;
    const int SMALL = 25000;
    const double BIG_BONUS = .10;
    const double SMALL_BONUS = .05;
    const double SMALLEST_BONUS = .03;

    static void Main()
    {
        Console.WriteLine("Casey Lance, CS1400-601");

        double sales;
        double salary = 1000.00;
        double commission;
        double pay;
        char response = 'y';


        Console.Write("Please enter the person's Sales: ");
        sales = double.Parse(Console.ReadLine());

         if (sales > BIG)
        {
            commission = sales * BIG_BONUS; 
        }
        else if (sales > SMALL)
        {
            commission = sales * SMALL_BONUS;
        }
        else
         {
             commission = sales * SMALLEST_BONUS;
         }
        pay = salary + commission;
        Console.WriteLine("This person's gross pay will be {0}", pay);


        Console.WriteLine("Thanks ... goodbye");
        Console.ReadLine();
    }
}

