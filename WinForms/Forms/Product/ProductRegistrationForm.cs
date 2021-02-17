using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.Forms.Product
{
    public partial class ProductRegistrationForm : Form
    {
        public ProductRegistrationForm()
        {
            InitializeComponent();
        }

        private void openlistbtn_Click(object sender, EventArgs e)
        {
            ProductDataForm form = new ProductDataForm();
            form.Show();
            this.Hide();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            ProductAddForm form = new ProductAddForm();
            form.Show();
            this.Hide();
        }

        private void ProductRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
