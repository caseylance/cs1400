//Casey Lance
//CS 1400
//Lab #7
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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
           private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Casey Lance\nCS1400\nLab #7");
        }

       

           
        private void processButton_Click(object sender, RoutedEventArgs e)
        {
            //Declare constants:
            //Constant for number of officers 
            const int NUMBER_OF_OFFICERS = 2;

            //Constant for number of gold given to crew for town:  
            const int CREW_GOLD_FOR_TOWN = 3;

            //Constant for twelve percent: 
            const double TWELVE_PERCENT = .12;

            //Constant  for eight percent: 
            const double EIGHT_PERCENT = .08;

            //Get total gold on ship
            int totalGold = int.Parse(totalGoldTxtBox.Text);

            //Get total number of pirates on ship
            int totalPirates = int.Parse(totalPiratesTxtBox.Text);

            //Get total number of pirates that are not the captain or first officer
            int totalCrew = totalPirates - NUMBER_OF_OFFICERS;

            //Get total amount of gold given to the crew for town
            int totalCrewMembersTownGold = totalCrew * CREW_GOLD_FOR_TOWN;

            //Get remaining gold after giving gold to crew for town
            int totalAfterCrewMemberTownGold = totalGold - totalCrewMembersTownGold;

            //Get twelve percent of gold for captain
            double captainsTwelvePercent = totalAfterCrewMemberTownGold * TWELVE_PERCENT;

            //Convert captainsTwelvePercent to an integer
            int intCaptainsTwelvePercent = (int)captainsTwelvePercent;

            //Deduct captains twelve percent from the remainder after the crews town gold
            int afterCaptainsTwelvePercent = totalAfterCrewMemberTownGold - intCaptainsTwelvePercent;

            //Get First Officer's eight percent
            double firstOfficersEightPercent = afterCaptainsTwelvePercent * EIGHT_PERCENT;

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
            int crewMemberTotalGold = crewSubTotal + CREW_GOLD_FOR_TOWN;

            //Modulus divide the total amount of gold by total number of pirates to get benevolent fund amount
            int totalBenevolentGold = totalToDivide % totalPirates;



            //Display captains gold amount
            string totalCaptainsGold = string.Format("{0:0}", captainsTotalGold);
            totalCaptainsGoldTxtBox.Text = totalCaptainsGold;

            //Display first officers gold amount
            string totalFirstOfficersGold = string.Format("{0:0}", firstOfficersTotalGold);
            totalFirstOfficersGoldTxtBox.Text = totalFirstOfficersGold;

            //Display crew member gold amount
            string totalCrewMemberGold = string.Format("{0:0}", crewMemberTotalGold);
            totalCrewMemberGoldTxtBox.Text = totalCrewMemberGold;


            //Display benevolent fund gold
            string totalBenevolentFundGold = string.Format("{0:0}", totalBenevolentGold);
            totalBenevolentFundGoldTxtBox.Text = totalBenevolentFundGold;
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            
            totalGoldTxtBox.Text = String.Empty;
            totalPiratesTxtBox.Text = String.Empty;
            totalCaptainsGoldTxtBox.Text = String.Empty;
            totalFirstOfficersGoldTxtBox.Text = String.Empty;
            totalCrewMemberGoldTxtBox.Text = String.Empty;
            totalBenevolentFundGoldTxtBox.Text = String.Empty;
            
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        }
    }
