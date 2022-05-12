using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap template method
    //ConcreteClass
    class Calculator_HoDanCu : CalculatorTemplate
    {
        public Calculator_HoDanCu(string phone) : base(phone){ }

        protected override float Calculator(float counter)
        {

            float cost = WaterCompany.getInstance().Water_HoDanCuCost;

            if (counter <= 4)
            {
                //cost 6.700f
                return counter * cost;
            }
            else if (counter > 4 && counter <= 6)
            {
                return counter * (cost + 6.200f);
            }
            else
            {
                return counter * (cost + 7.700f);
            }
        }
    }
}
