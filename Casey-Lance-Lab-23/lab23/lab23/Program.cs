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
            {
                Console.WriteLine("Enter value {0} in the array:", (i+1));
                int arrayValue = arrayForLab[i];
                arrayForLab[i] = int.Parse(Console.ReadLine());
            }

            foreach (int value in arrayForLab)
            {
                Console.Write(" {0}", value);
            }
                
            
            int valueTotal = TotalArray(arrayForLab);

            Console.WriteLine("\n{0}", valueTotal);


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
    }
}
