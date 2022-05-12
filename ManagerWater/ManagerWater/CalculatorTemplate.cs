using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{

    //Ap template method
    //Abstract class
    //Client cua adapter pattern
    abstract class CalculatorTemplate
    {

        public string customer_phone;

        public Customers Customers { get; set; }
        protected CalculatorTemplate(string phone)
        {
            this.customer_phone = phone;
        }

        //Lay nguoi dung
        protected Customers getCustomer()
        {
            CustomerSql customerSql = new CustomerSql();

            return customerSql.findCustomer(customer_phone);
        }

        //Lay so met khoi da su dung
        protected float getCounter()
        {
            CubicMetreSql cubicMetreSql = new CubicMetreSql();

            CubicMetre cubicMetre = cubicMetreSql.findCubicMetre(Customers.CubicMetre_ID);

            float counter = cubicMetre.CubicMetre_count;

            return counter;
        }

        protected abstract float Calculator(float counter);

        //Ham tinh tien nuoc
        public float Pay()
        {
            this.Customers = getCustomer();
            float pay = Calculator(getCounter());
            return pay;
        }

    }
}
