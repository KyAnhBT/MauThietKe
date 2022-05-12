using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    internal class Calculator_KinhDoanh : CalculatorTemplate
    {
        public Calculator_KinhDoanh(string phone) : base(phone) { }
        protected override float Calculator(float counter)
        {
            float cost = WaterCompany.getInstance().Water_KinhDoanhCost;
            //cost 21.300f
            return counter * cost;
        }
    }
}
