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
    public partial class CustomersUpdateForm : Form
    {
        public CustomersUpdateForm()
        {
            InitializeComponent();
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

        private void updatebtnn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerRegistrationManager manager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());
                manager.Update(new Entities.Concrete.CustomerRegistration
                {
                    NewCustomerName = nametxb.Text,
                    NewCustomerSurname = surnametxb.Text,
                    NewCustomerTelephoneNo = Convert.ToInt32(telephonetxb.Text),
                    NewCustomerId = Convert.ToInt32(notxb.Text),
                    Mail = emailtxb.Text,
                    Adress = adresstxb.Text
                });
                MessageBox.Show(Messages.UpdateSuccess);
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tbox = (TextBox)item;
                        tbox.Clear();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.UpdateError);

            }
        }
        public string no, name, surname, telephone, email, adress;

        private void exitpng_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CustomersUpdateForm_Load(object sender, EventArgs e)
        {
            notxb.Text = no;
            nametxb.Text = name;
            surnametxb.Text = surname;
            telephonetxb.Text = telephone;
            emailtxb.Text = email;
            adresstxb.Text = adress;
        }
    }
}
