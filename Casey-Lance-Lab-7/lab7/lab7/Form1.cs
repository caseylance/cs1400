using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class totalBenevolentGold : Form
    {
        public totalBenevolentGold()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get total gold on ship
            int totalGold = int.Parse(totalGoldTxtBox.Text);

            //Get total number of pirates on ship
            int totalPirates = int.Parse(totalPiratesTxtBox.Text);

            //Get total number of pirates that are not the captain or first officer
            int totalCrew = totalPirates - 2;

            //Get total amount of gold given to the crew for town
            int totalCrewMembersTownGold = totalCrew * 3;

            //Get remaining gold after giving gold to crew for town
            int totalAfterCrewMemberTownGold = totalGold - totalCrewMembersTownGold;

            //Get twelve percent of gold for captain
            double captainsTwelvePercent =  totalAfterCrewMemberTownGold * .12;

            //Convert captainsTwelvePercent to an integer
            int intCaptainsTwelvePercent = (int)captainsTwelvePercent;
       
            //Deduct captains twelve percent from the remainder after the crews town gold
            int afterCaptainsTwelvePercent = totalAfterCrewMemberTownGold - intCaptainsTwelvePercent;
            
            //Get First Officer's eight percent
            double firstOfficersEightPercent = afterCaptainsTwelvePercent * .08;
            
            //Convert First Officer's eight percent to an integer
            int intFirstOfficersEightPercent = (int)firstOfficersEightPercent;
            
            //Deduct first officer's eight percent from remaining after deducting the captains 12 percent
            
            int totalToDivide = afterCaptainsTwelvePercent - intFirstOfficersEightPercent;
            
            //Divde remaining gold after captain and first officers share by total pirates
            
            int crewSubTotal = totalToDivide / totalPirates;

            //add total amount per crew member to captains twelve percent to get his total
            int captainsTotalGold = crewSubTotal + intCaptainsTwelvePercent;

            //add total amount per crew member to first officer's eight percent to get his total
            int firstOfficersTotalGold = crewSubTotal + intFirstOfficersEightPercent;
            
            //add three to the amount per crew member to get the total amount per crew member
            int crewMemberTotalGold = crewSubTotal + 3;
            
            //Modulus divide the total amount of gold by total number of pirates to get benevolent fund amount
            int totalBenevolentGold = totalToDivide % totalPirates;
                    


            //Display captains gold amount
            string totalCaptainsGold = string.Format("{0:0.0}", captainsTotalGold);
            totalCaptainsGoldTxtBox.Text = totalCaptainsGold;

            //Display first officers gold amount
            string totalFirstOfficersGold = string.Format("{0:0.0}", firstOfficersTotalGold);
            totalFirstOfficersGoldTxtBox.Text = totalFirstOfficersGold;

            //Display crew member gold amount
            string totalCrewMemberGold = string.Format("{0:0.0}", crewMemberTotalGold);
            totalCrewMemberGoldTxtBox.Text = totalCrewMemberGold;

         
            //Display benevolent fund gold
            string totalBenevolentFundGold = string.Format("{0:0.0}", totalBenevolentGold);
            totalBenevolentFundGoldTxtBox.Text = totalBenevolentFundGold;
            
        
            
        }
    }
}
