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

namespace WinForms.Forms.Product
{
    public partial class ProductUpdateForm : Form
    {
        public ProductUpdateForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                ProductRegistrationManager manager = new ProductRegistrationManager(new EfProductRegistrationDAL());
                manager.Update(new Entities.Concrete.ProductRegistration
                {
                    NewProductId = Convert.ToInt32(productnotxb.Text),
                    NewProductName = productnametxb.Text,
                    NewProductPrice = Convert.ToInt32(productpricetxb.Text),
                    NewProductQuantity = Convert.ToInt32(productquantitytxb.Text),
                    NewProductImage = productımagetxb.Text

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
        public string no, name, price, quantity, Image;
        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            productnotxb.Text = no;
            productnametxb.Text = name;
            productpricetxb.Text = price;
            productquantitytxb.Text = quantity;
            productımagetxb.Text = Image;
        }
    }
}
