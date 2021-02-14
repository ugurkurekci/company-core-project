using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Login : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Login()
        {
            InitializeComponent();
        }




        private void Login_Load(object sender, EventArgs e)
        {
            panelsaydam.BackColor = Color.FromArgb(100, 0, 0, 0);

        }


        private void Exitpng_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usernametxb_TextChanged_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.DarkBlue;
        }

        private void Passwordtxb_TextChanged_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.DarkBlue;
        }

        private void panelheader_MouseDown_1(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panelheader_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }

        }

        private void panelheader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Registerbtn_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
            
        }
    }
}
