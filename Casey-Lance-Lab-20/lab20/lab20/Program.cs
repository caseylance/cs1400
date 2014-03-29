using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to roll the dice? Enter Y or N");
            char userResponse = char.Parse(Console.ReadLine());
            userResponse = char.ToUpper(userResponse);
            
            while (userResponse != 'Y' && userResponse != 'N')
            {
                Console.WriteLine("You must enter either Y or N");
                userResponse = char.Parse(Console.ReadLine());
            }
            
            while (userResponse == 'Y')
            {
                Random randomNums = new Random();
                int diceOne = randomNums.Next(1, 7);
                int diceTwo = randomNums.Next(1, 7);

                if (diceOne == 1 && diceTwo == 1)
                {
                    Console.WriteLine("You rolled snake eyes.");
                }

                else if (diceOne == 6 && diceTwo == 6) 
                {
                    Console.WriteLine("You rolled box cars");
                }

                else
                {
                    Console.WriteLine("You rolled {0} and {1}", diceOne, diceTwo);
                }

                Console.WriteLine("Would you like to play again?  Enter Y or N");
                userResponse = char.Parse(Console.ReadLine());
                userResponse = char.ToUpper(userResponse);

                while (userResponse != 'Y' && userResponse != 'N')
                {
                    Console.WriteLine("You must enter either Y or N");
                    userResponse = char.Parse(Console.ReadLine());
                }
            }
            
            

            if (userResponse == 'N')
            {
                Console.WriteLine("Goodbye!");
            }
            Console.ReadLine();
        }
    }
}
