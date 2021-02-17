using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.Forms.Order
{
    public partial class OrderAddForm : Form
    {
        public OrderAddForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OrderAddForm form = new OrderAddForm();
            this.Hide();
            form.Close();
        }

        private void OrderAddForm_Load(object sender, EventArgs e)
        {
            CustomerRegistrationManager manager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());

            foreach (var item in manager.GetAll().Data)
            {
                namecbx.Items.Add(item.NewCustomerName);
                surnamecbx.Items.Add(item.NewCustomerSurname);

            }
            ProductRegistrationManager manager2 = new ProductRegistrationManager(new EfProductRegistrationDAL());
            foreach (var item in manager2.GetAll().Data)
            {
                productcbx.Items.Add(item.NewProductName);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SoldProductManager manager = new SoldProductManager(new EfSoldProductDAL());
                var result = manager.Add(new SoldProduct
                {
                    BuyerName = namecbx.Text,
                    BuyerSurname = surnamecbx.Text,
                    BuyerProject = productcbx.Text,
                    BuyerPrice = Convert.ToInt32(pricetxb.Text),
                    BuyerQuantity = Convert.ToInt32(quantitytxb.Text)
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

