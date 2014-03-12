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
        private double shippingSpeed;
        private double surchargeValue;
        private double categoryValue;
        private double numberOfItems;
        private const double standardItemRate = 3.00;
        private const double standardWeightRate = 1.45;
        private const double expressItemRate = 4.00;
        private const double expressWeightRate = 2.50;
        private const double sameDayItemRate = 5.50;
        private const double sameDayWeightRate = 3.00;
        private const double standardSurcharge = 2.50;
        private const double expressSurcharge = 5.00;
        private const double sameDaySurcharge = 8.00;
        double shippingCost;

        //Default Constructor
        //Purpose:  Set declared variabled to 0
        public ShippingCost()
        { 
            shippingSpeed = 0;
            surchargeValue = 0;
            categoryValue = 0;
            numberOfItems = 0;
            
          }

        //Parameterzed constructor
        //Purpose:  Sets all declared variables to the values passed in
        public ShippingCost(double p1, double p2, double p3, double p4)
        {
            shippingSpeed = p1;
            surchargeValue = p2;
            categoryValue = p3;
            numberOfItems = p4;

         }

        //The CalcShippingCost Method
        //Purpose:  To return the shipping cost value
        //Returns:  A double shipping cost value
        public double CalcShippingCost()
        {
                    
            if (shippingSpeed == 0)
            {
                if (categoryValue == 0)
                {
                    if (surchargeValue == 1)
                    {
                        shippingCost = (numberOfItems * standardItemRate) + standardSurcharge;
                    }
                    else if (surchargeValue == 0)
                    {
                        shippingCost = numberOfItems * standardItemRate;
                    }
                }
                else if (categoryValue == 1)
                {
                    if (surchargeValue == 1)
                    {
                        shippingCost = (numberOfItems * standardWeightRate) + standardSurcharge;
                    }
                    else if (surchargeValue == 0)
                    {
                        shippingCost = numberOfItems * standardWeightRate;
                    }
                }
            }
            
            else if (shippingSpeed == 1 && categoryValue == 0)
                if (surchargeValue == 1)
                    shippingCost = (numberOfItems * expressItemRate) + standardSurcharge;
                else if (surchargeValue == 0)
                    shippingCost = numberOfItems * expressItemRate;

                else if (shippingSpeed == 1 && categoryValue == 1)
                    if (surchargeValue == 1)
                        shippingCost = (numberOfItems * expressWeightRate) + expressSurcharge;
                    else if (surchargeValue == 0)
                        shippingCost = numberOfItems * expressWeightRate;

                    else if (shippingSpeed == 1 && categoryValue == 0)
                        if (surchargeValue == 1)
                            shippingCost = (numberOfItems * expressItemRate) + expressSurcharge;
                        else if (surchargeValue == 0)
                            shippingCost = numberOfItems * expressItemRate;

                        else if (shippingSpeed == 2 && categoryValue == 1)
                            if (surchargeValue == 1)
                                shippingCost = (numberOfItems * sameDayWeightRate) + sameDaySurcharge;
                            else if (surchargeValue == 0)
                                shippingCost = numberOfItems * sameDayWeightRate; 

            
            return shippingCost;
        }

    }
}
