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
    public partial class ProductAddForm : Form
    {
        public ProductAddForm()
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
            ProductAddForm form = new ProductAddForm();
            this.Hide();
            form.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProductRegistrationManager manager = new ProductRegistrationManager(new EfProductRegistrationDAL());
                var result = manager.Add(new Entities.Concrete.ProductRegistration
                {
                    NewProductName = nametxb.Text,
                    NewProductPrice = Convert.ToInt32(pricetxb.Text),
                    NewProductQuantity = Convert.ToInt32(quantitytxb.Text),
                    NewProductImage = ımagetxb.Text,


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

        private void headerpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
