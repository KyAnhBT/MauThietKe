using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Tao concreteClass cho CalcullatorTemplate
    class CalculatorFactory
    {
        public CalculatorFactory() { }
        public static CalculatorTemplate getCalculatorTemplate(string kind, string phone)
        {
            if (kind == "Ho dan cu")
            {
                return new Calculator_HoDanCu(phone);
            }
            else if (kind == "San xuat")
            {
                return new Calculator_SanXuat(phone);
            }
            else if (kind == "Co quan hanh chinh")
            {
                return new Calculator_CoquanHanhchinh(phone);
            }
            else
            {
                return new Calculator_KinhDoanh(phone);
            }
        }
    }
}
