using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.Forms.Customers
{
    public partial class CustomersAddForm : Form
    {
        public CustomersAddForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomersAddForm form = new CustomersAddForm();
            this.Hide();
            form.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerRegistrationManager manager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());
                var result = manager.Add(new Entities.Concrete.CustomerRegistration
                {
                    NewCustomerName = nametxb.Text,
                    NewCustomerSurname = surnametxb.Text,
                    NewCustomerTelephoneNo = Convert.ToInt32(telephonetxb.Text),
                    Mail = emailtxb.Text,
                    Adress = adresstxb.Text

                });
                if (result.Success)
                {
                    MessageBox.Show(Messages.SuccessAdded);
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox tbox = (TextBox)item;
                            tbox.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Messages.ErrorAdded);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Messages.Error, ex.Message);
            }
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void headerpnl_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void headerpnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void headerpnl_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
    }
}
