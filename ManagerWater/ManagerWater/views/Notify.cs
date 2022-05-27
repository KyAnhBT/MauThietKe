using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class Notify : Form
    {

        Customers customers = new Customers();
        CubicMetre cubicMetre = new CubicMetre();

        public int cubicMetre_id;
        public Notify()
        {
            InitializeComponent();
        }

        private void btn_convertToDollar_Click(object sender, EventArgs e)
        {
            float money = float.Parse(lb_Pay.Text.ToString());

            //chuyen vnd sang dollar
            VNDTarget vNDTarget = new Adapter_VNDToDollar(new DollarAdaptee());
            float moneyConverted = vNDTarget.change(money);
            //Làm tròn 2 chữ số Math.Round
            lb_dollar.Text = Math.Round(moneyConverted, 2) + " $";
        }

        private void btn_convertToEuro_Click(object sender, EventArgs e)
        {
            float money = float.Parse(lb_Pay.Text.ToString());

            //chuyen vnd sang euro
            VNDTarget vNDTarget = new Adapter_VNDToEuro(new EuroAdaptee());
            float moneyConverted = vNDTarget.change(money);
            //Làm tròn 2 chữ số Math.Round
            lb_dollar.Text = Math.Round(moneyConverted, 2) + " EUR ";

        }

        private void Notify_Load(object sender, EventArgs e)
        {
            Customers customer = customers.findCustomer(Program.phone);
            WaterCompanyObserver waterCompanyObserver = WaterCompanyObserver.getWaterCompanyObserver();
            //Observer
            CostDisplay costDisplay = new CostDisplay(waterCompanyObserver, 0, customer.Customer_phone, lb_Pay, lb_used, lb_cost);
        }
    }
}
