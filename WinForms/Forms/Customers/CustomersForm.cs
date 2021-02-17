using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.Forms.Customers
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            CustomersAddForm form = new CustomersAddForm();
            form.Show();
            this.Hide();
        }

        private void openlistbtn_Click(object sender, EventArgs e)
        {
            CustomersDataForm form = new CustomersDataForm();
            form.Show();
            this.Hide();
        }
    }
}
