using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class AboutCompany : Form
    {
        public AboutCompany()
        {
            InitializeComponent();
        }

        private void AboutCompany_Load(object sender, EventArgs e)
        {
            txtCompany.Text = WaterCompany.getInstance().Company_name;
            txt_address.Text = WaterCompany.getInstance().Company_address;
            txt_phone.Text = WaterCompany.getInstance().Company_phone;
            txt_leader.Text = WaterCompany.getInstance().Company_leader;
            txt_fax.Text = WaterCompany.getInstance().Company_fax;
        }
    }
}
