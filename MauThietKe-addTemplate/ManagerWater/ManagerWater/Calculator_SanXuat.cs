using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap template method
    //ConcreteClass
    class Calculator_SanXuat : CalculatorTemplate
    {
        public Calculator_SanXuat(string phone) : base(phone){ }
        protected override float Calculator(float counter)
        {
            float cost = WaterCompany.getInstance().Water_SanXuatCost;
            //cost 12.100f
            return counter * cost;
        }
    }
}
