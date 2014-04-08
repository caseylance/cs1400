//Casey Lance
//CS 1400
//Project #8
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

namespace project8
{
    class Dice
    {
        
        private int diceOneValue;
        private int diceTwoValue;
        private string informationalMessage;
        
        
        public Dice()
        {
            RoleDices(ref diceOneValue, ref diceTwoValue);
            GenerateInformationalMessage(ref informationalMessage);
        }
               
        private void RoleDices(ref int d1, ref int d2)
        {
                Random randomNums = new Random();
                d1= randomNums.Next(1, 7);
                d2 = randomNums.Next(1, 7);
        } 

        private void GenerateInformationalMessage (ref string st1)
        {
            if (diceOneValue == 1 && diceTwoValue == 1)
            {
                informationalMessage = "You got snake eyes!";
            }
            else if (diceOneValue == 5 && diceTwoValue == 5)
            {
                informationalMessage = "You got boxcars!";
            }
            else
            {
                informationalMessage = "";
            }
        }

        public int GetDiceOneValue()
        {
            return diceOneValue;
        }

        public int GetDiceTwoValue()
        {
            return diceTwoValue;
        }

        public string GetInformationalMessage()
        {
            return informationalMessage;
        }    
    }

}
