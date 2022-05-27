using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class Info : Form
    {
        Customers customers = new Customers();
        CubicMetre cubicMetre = new CubicMetre();

        public int cubicMetre_id;

        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            Customers customer = customers.findCustomer(Program.phone);
            this.cubicMetre_id = customer.CubicMetre_ID;

            //Load thong tin len man hinh nguoi dung
            customer_phone.Text = customer.Customer_phone.ToString();
            customer_name.Text = customer.Customer_name.ToString();
            customer_address.Text = customer.Customer_address.ToString();
            customer_kind.Text = customer.Customer_kind.ToString();
            if (customer.CubicMetre_ID.ToString() == "0")
            {
                cubicmetre_id.ForeColor = Color.Red;
                cubicmetre_id.Text = "Chưa đăng ký đồng hồ";
            }
            else
            {
                cubicmetre_id.Text = customer.CubicMetre_ID.ToString();
                CubicMetre c = cubicMetre.findCubicMetre(int.Parse(cubicmetre_id.Text));
            }

        }
    }
}
