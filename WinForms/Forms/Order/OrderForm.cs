using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.Forms.Sold
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Order.OrderAddForm form = new Order.OrderAddForm();
            form.Show();
            this.Hide();
        }

        private void openlistbtn_Click(object sender, EventArgs e)
        {
            Order.OrderDataForm form = new Order.OrderDataForm();
            form.Show();
            this.Hide();
        }
    }
}
