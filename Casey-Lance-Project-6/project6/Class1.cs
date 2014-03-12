//Casey Lance
//CS 1400
//Project #6
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

namespace project6
{
    class ShippingCost
    {
        //The data members of the class
        private string shippingSpeed;
        private string surchargeValue;
        private string shippingUnit;
        private double numberOfItems;
        private double shippingCost;
        private double unitCost;
        private double surchargeCalcValue;

        //Default Constructor
        //Purpose:  Set declared variabled to 0
        public ShippingCost()
        { 
            shippingSpeed = null;
            surchargeValue = null;
            shippingUnit = null;
            numberOfItems = 0;
            
          }

        //Parameterzed constructor
        //Purpose:  Sets all declared variables to the values passed in
        public ShippingCost(string p1, string p2, string p3, double p4)
        {
            shippingSpeed = p1;
            surchargeValue = p2;
            shippingUnit = p3;
            numberOfItems = p4;
         }

        //The CalcShippingCost Method
        //Purpose:  To return the shipping cost value
        //Returns:  A double shipping cost value
        public double CalcShippingCost()
        {
            if (shippingSpeed == "standard" && shippingUnit == "item")
            {
                if (surchargeValue == "true")
                {
                    unitCost = 3.00;
                    surchargeCalcValue = 2.50;
                }
                else if (surchargeValue == "false")
                {
                    unitCost = 3.00;
                    surchargeCalcValue = 0;
                }
            }
            else if (shippingSpeed == "standard" && shippingUnit == "weight")
            {
                if (surchargeValue == "true")
                {
                    unitCost = 1.45;
                    surchargeCalcValue = 2.50;
                }
                else if (surchargeValue == "false")
                {
                    unitCost = 1.45;
                    surchargeCalcValue = 0;
                }
            }
            else if (shippingSpeed == "express" && shippingUnit == "item")
            {
                if (surchargeValue == "true")
                {
                    unitCost = 4.00;
                    surchargeCalcValue = 5.00;
                }
                else if (surchargeValue == "false")
                {
                    unitCost = 4.00;
                    surchargeCalcValue = 0;
                }
            }
            else if (shippingSpeed == "express" && shippingUnit == "weight")
            {
                if (surchargeValue == "true")
                {
                    unitCost = 2.50;
                    surchargeCalcValue = 5.00;
                }
                else if (surchargeValue == "false")
                {
                    unitCost = 2.50;
                    surchargeCalcValue = 0;
                }
            }
            else if (shippingSpeed == "same_day" && shippingUnit == "item")
            {
                if (surchargeValue == "true")
                {
                    unitCost = 5.50;
                    surchargeCalcValue = 8.00;
                }
                else if (surchargeValue == "false")
                {
                    unitCost = 5.50;
                    surchargeCalcValue = 0;
                }
            }
            else if (shippingSpeed == "same_day" && shippingUnit == "weight")
            {
                if (surchargeValue == "true")
                {
                    unitCost = 3.00;
                    surchargeCalcValue = 8.00;
                }
                else if (surchargeValue == "false")
                {
                    unitCost = 3.00;
                    surchargeCalcValue = 0;
                }
            }            
            shippingCost = (unitCost * numberOfItems) + surchargeCalcValue;
            return shippingCost;
        }

    }
}
