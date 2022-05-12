using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    public class WaterCompany
    {
        //Thông tin công ty nước
        public string Company_name;
        public string Company_address;
        public string Company_phone;

        // Giá nước
        public float Water_HoDanCuCost = 6.700f;
        public float Water_SanXuatCost = 12.100f;
        public float Water_CoquanHanhchinhCost = 13.000f;
        public float Water_KinhDoanhCost = 21.300f;



        //Ham get set
        public string company_name { get; set; }
        public string company_address { get; set; }
        public string conpany_phone { get; set; }

        //Áp dụng singleton(Vì app này sử dụng duy nhất cho 1 công ty)
        private static WaterCompany instance;

        private WaterCompany() { }

        public static WaterCompany getInstance()
        {
            if (instance == null)
            {
                instance = new WaterCompany();
            }
            return instance;
        }
    }
}
