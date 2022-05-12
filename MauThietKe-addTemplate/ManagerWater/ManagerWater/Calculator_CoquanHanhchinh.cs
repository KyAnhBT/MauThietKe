using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap template method
    //ConcreteClass
    class Calculator_CoquanHanhchinh: CalculatorTemplate
    {
        public Calculator_CoquanHanhchinh(string phone) : base(phone){ }
        protected override float Calculator(float counter)
        {
            float cost = WaterCompany.getInstance().Water_CoquanHanhchinhCost;
            //cost 13.000f
            return counter * cost;
        }
    }
}
