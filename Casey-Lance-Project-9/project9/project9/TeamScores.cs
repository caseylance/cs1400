using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project9
{
    class BowlingTeam
    {
        private static string userInputString;
        string playerName = "";
        string playerScore = "";

        public BowlingTeam()
        {
          string  userInputString = "";
        }



        //Number of players
        //Array of first names
        //Array of scores

        //Method to calculate high score
        //Method to calculate low score
        //Method to calculate average score



        public void SetUserInput(string input)
        {
           string userInputString = input;
        }

        public void CreateArray(string inputFromUser)
        {
            string[] scoreInfo = userInputString.Split();
            // Parse each element of the array into the correct data type
            string name = scoreInfo[0];
            int score = int.Parse(scoreInfo[1]);
        }

       // public double CalcAverageScore();
        //public int  HighScore();
        //public int LowScore();
    }
}
