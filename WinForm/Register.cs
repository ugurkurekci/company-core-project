using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Register : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Register()
        {
            InitializeComponent();
        }

        private void Panelheader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void Panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void Panelheader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Exitpng_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usernametxb_TextChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.DarkBlue;
        }

        private void usernamemail_TextChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.DarkBlue;
        }

        private void usernamepassw_TextChanged(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DarkBlue;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            AdminManager manager = new AdminManager(new EfAdminDAL());
            manager.Add(new Entities.Concrete.Admin { Name = Usernametxb.Text, Passw = Passtxb.Text, Mail = Emailtxb.Text });
            MessageBox.Show("Okey ✓");



        }

        
    }
}
