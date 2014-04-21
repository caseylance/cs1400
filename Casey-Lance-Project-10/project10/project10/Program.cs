using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project10
{
    class Program
    {
        const int ITEMS = 100;
        static void Main(string[] args)
        {
            string [] userInputArray = new string [ITEMS];
            int indexArray =0;
            int arrayItemElement = 0;
            string userInput;
            string[] parsedInput;
            string[] namesArray = new string[ITEMS];
            int[] scoresArray = new int[ITEMS];
            //string[] name;
            //int[] score;

            do
            {
                
                arrayItemElement++;
                Console.WriteLine("Enter the first name and score and hit enter.  Enter a blank line to stop:");
                userInput = (Console.ReadLine());
                parsedInput = userInput.Split();
                //string name = parsedInput[0];

                if (userInput != "")
                {
                    //userInputArray[indexArray++] = userInput;
                    parsedInput = userInput.Split();
                    string name = parsedInput[0];
                    int score = int.Parse(parsedInput[1]);
                    scoresArray[indexArray] = score;
                    namesArray[indexArray] = name;
                    indexArray++;

                }
            } while (userInput != "" && indexArray < ITEMS);

            Console.WriteLine("\nThe elements in the array are:");

            for (int i=0; i < indexArray; i++)
            {
                Console.Write("{0} ", scoresArray[i]);
                // Console.Write("\n{0} ", namesArray[i]);
            }

            for (int i = 0; i < indexArray; i++)
            {
                //Console.Write("{0} ", scoresArray[i]);
                Console.Write("\n{0} ", namesArray[i]);
            }

            double averageScore = ArrayAverage(scoresArray, indexArray);
            Console.WriteLine("\n\nThe average score is:");
            Console.WriteLine("{0:f2}", averageScore);
            Console.ReadLine();

            for (int j = 0; j < indexArray - 1; j++)
            {
                for (int i = 0; i < indexArray - 1; i++)
                {
                    if (scoresArray[i] < scoresArray[i + 1])
                    {
                        Swap(ref scoresArray[i], ref scoresArray[i + 1]);
                        Swap(ref namesArray[i], ref namesArray[i + 1]);
                    }
                }
            }

            for (int i = 0; i < indexArray; i++)
            {
                if (scoresArray[i] == 300)
                {
                    Console.Write("\n{0} - {1}* ", namesArray[i], scoresArray[i]);
                }
                else
                {
                    Console.Write("\n{0} - {1}", namesArray[i], scoresArray[i]);
                }

                
            }

            Console.ReadLine();


        }

        static double ArrayAverage (int[] scoresArray, int size)
        {
            double arrayAverage = 1;
            double arraySum = 0;

            for(int i = 0; i <= size; i++)
            {
                arraySum += scoresArray[i];
            }
            arrayAverage = arraySum / size;
            return arrayAverage;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}
