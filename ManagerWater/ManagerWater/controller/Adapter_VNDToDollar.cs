using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Áp dụng adapter pattern
    //Adapter
    class Adapter_VNDToDollar: VNDTarget
    {
        public DollarAdaptee dollarAdaptee;

        public Adapter_VNDToDollar(DollarAdaptee dollarAdaptee)
        {
            this.dollarAdaptee = dollarAdaptee;
        }

        public float change(float money)
        {
            float dollar = this.dollarAdaptee.VndToDollar(money);
            return dollar;
        }
    }


    //Adaptee
    class DollarAdaptee
    {
        //Chuyển từ VNĐ sang Dollar
        public float VndToDollar(float money)
        {
            return money / 23.0f;
        }
    }

}
