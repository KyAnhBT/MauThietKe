using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Notify f = new Notify();
            AddForm(f);
        }

        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void notifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notify f = new Notify();
            AddForm(f);
        }

        private void deviceManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Device_Management f = new Device_Management();
            AddForm(f);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info f = new Info();
            AddForm(f);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCompany f = new AboutCompany();
            AddForm(f);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
