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
            double totalGold = double.Parse(totalGoldTxtBox.Text);

            //Get total number of pirates on ship
            double totalPirates = double.Parse(totalPiratesTxtBox.Text);

            //Get total number of pirates that are not the captain or first officer
            double totalCrew = totalPirates - 2;

            //Get total amount of gold given to the crew for town
            double totalCrewMembersTownGold = totalCrew * 3;

            //Get remaining gold after giving gold to crew for town
            double totalAfterCrewMemberTownGold = totalGold - totalCrewMembersTownGold;

            //Get twelve percent of gold for captain
            double captainsTwelvePercent = totalAfterCrewMemberTownGold * .12;
       
            //Deduct captains twelve percent from the remainder after the crews town gold
            double afterCaptainsTwelvePercent = totalAfterCrewMemberTownGold - captainsTwelvePercent;
           

            //Get First Officer's eight percent
            double firstOfficersEightPercent = afterCaptainsTwelvePercent * .08;
            
            
            //Deduct first officer's eight percent from remaining after deducting the captains 12 percent
            
            double totalToDivide = afterCaptainsTwelvePercent - firstOfficersEightPercent;
            
            //Divde remaining gold after captain and first officers share by total pirates
            double crewSubTotal = totalToDivide / totalPirates;
            //add total amount per crew member to captains twelve percent to get his total
            double captainsTotalGold = crewSubTotal + captainsTwelvePercent;
            //add total amount per crew member to first officer's eight percent to get his total
            double firstOfficersTotalGold = crewSubTotal + firstOfficersEightPercent;
            //add three to the amount per crew member to get the total amount per crew member
            double crewMemberTotalGold = crewSubTotal;
            //Modulus divide the total amount of gold by total number of pirates to get benevolent fund amount
            double totalBenevolentGold = totalToDivide % totalPirates;
          
            


            //Display captains gold amount
            int intCaptainsTotalGold = (int)captainsTotalGold;
            string totalCaptainsGold = string.Format("{0:0.0}", intCaptainsTotalGold);
            totalCaptainsGoldTxtBox.Text = totalCaptainsGold;

            //Display first officers gold mount
            int intFirstOfficersTotalGold = (int)firstOfficersTotalGold;
            string totalFirstOfficersGold = string.Format("{0:0.0}", intFirstOfficersTotalGold);
            totalFirstOfficersGoldTxtBox.Text = totalFirstOfficersGold;

            //Display crew member gold amount
            int intCrewMemberTotalGold = (int)crewMemberTotalGold;
            string totalCrewMemberGold = string.Format("{0:0.0}", intCrewMemberTotalGold);
            totalCrewMemberGoldTxtBox.Text = totalCrewMemberGold;

            double ben = (captainsTotalGold - intCaptainsTotalGold) + (firstOfficersTotalGold - intFirstOfficersTotalGold) + ((crewMemberTotalGold *totalCrew) - (intCrewMemberTotalGold * totalCrew));

            //Display benevelont fund gold
            //string totalBenevolentFundGold = string.Format("{0:0.0}", totalBenevolentGold);
            //totalBenevolentFundGoldTxtBox.Text = totalBenevolentFundGold;

            string totalBenevolentFundGold = string.Format("{0:0.0}", ben);
            totalBenevolentFundGoldTxtBox.Text = totalBenevolentFundGold;
           
            
        }
    }
}
