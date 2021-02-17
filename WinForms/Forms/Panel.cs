using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForms.Forms.Sold;

namespace WinForms.Forms
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void headerpnl_Move(object sender, EventArgs e)
        {

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
            Application.Exit();
        }

        private void AboutMebtn_Click(object sender, EventArgs e)
        {
            AboutMe.AboutMeForm about = new AboutMe.AboutMeForm();
            panel1.Controls.Clear();
            about.MdiParent = this;
            about.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(about);
            about.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Authorizedbtn_Click(object sender, EventArgs e)
        {
            Authorized.AuthorizedForm authorizedform = new Authorized.AuthorizedForm();
            panel1.Controls.Clear();
            authorizedform.MdiParent = this;
            authorizedform.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(authorizedform);
            authorizedform.Show();

        }

        private void headerpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers.CustomersForm form = new Customers.CustomersForm();
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product.ProductRegistrationForm form = new Product.ProductRegistrationForm();
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
