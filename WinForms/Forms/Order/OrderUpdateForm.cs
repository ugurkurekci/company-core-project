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

namespace WinForms.Forms.Order
{
    public partial class OrderUpdateForm : Form
    {
        public OrderUpdateForm()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                SoldProductManager manager = new SoldProductManager(new EfSoldProductDAL());
                manager.Update(new Entities.Concrete.SoldProduct
                {s
                    BuyerName = namecbx.Text,
                    BuyerSurname = surnamecbx.Text,
                    BuyerProject = productcbx.Text,
                    BuyerId = Convert.ToInt32(notxb.Text),
                    BuyerPrice = Convert.ToInt32(pricetxb.Text),
                    BuyerQuantity = Convert.ToInt32(quantitytxb.Text)
                }) ;
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
        public string no, name, surname, product, price, quantity;
        private void OrderUpdateForm_Load(object sender, EventArgs e)
        {
            notxb.Text = no;
            namecbx.Items.Add(name);
            surnamecbx.Items.Add(surname);
            productcbx.Items.Add(product);
            pricetxb.Text = price;
            quantitytxb.Text = quantity;
        }
    }
}
