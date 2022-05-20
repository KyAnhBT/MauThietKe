using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Áp dụng adapter pattern
    //Adapter
    class Adapter_VNDToEuro : VNDTarget
    {
        public EuroAdaptee euroAdaptee;

        public Adapter_VNDToEuro(EuroAdaptee euroAdaptee)
        {
            this.euroAdaptee = euroAdaptee;
        }

        public float change(float money)
        {
            float euro = this.euroAdaptee.VndToEuro(money);
            return euro;
        }
    }


    //Adaptee
    class EuroAdaptee
    {
        //Chuyển từ VNĐ sang Euro
        public float VndToEuro(float money)
        {
            return money / 24.0f;
        }
    }

}
