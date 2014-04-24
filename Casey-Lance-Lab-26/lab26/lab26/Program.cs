// Name: Casey Lance
// CS 1400 - 601
//Lab 26
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
using System.IO;

namespace lab26
{
    class Program
    {
        const int ITEMS = 50;
        static void Main(string[] args)
        {
            string environment = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\";
            string fileName = "grades.txt";
            string path = environment+fileName;
            string scoreString;
            int score;
            int indexArray = 0;
            int[] scoresArray = new int[ITEMS];

            Console.WriteLine("The scores are as follows:");
            StreamReader myFile = new StreamReader(path);
            do {
                scoreString = myFile.ReadLine();
                Console.WriteLine("{0}", scoreString);
                if (scoreString != null)
                {
                    score = int.Parse(scoreString);
                    scoresArray[indexArray] = score;
                    indexArray++;
                }
            } while (scoreString != null && indexArray < ITEMS);

            double averageScore = ArrayAverage(scoresArray, indexArray);
            Console.WriteLine("The average score is:");
            Console.WriteLine("{0:f2}", averageScore);
            Console.ReadLine();             
        }

        static double ArrayAverage(int[] scoresArray, int size)
        {
            double arrayAverage = 1;
            double arraySum = 0;

            for (int i = 0; i < size; i++)
            {
                arraySum += scoresArray[i];
            }
            arrayAverage = arraySum / size;
            return arrayAverage;
        }
    }
}
