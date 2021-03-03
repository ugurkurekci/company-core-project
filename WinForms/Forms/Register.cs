using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void passwordtxb_TextChanged(object sender, EventArgs e)
        {

            emailpnl.BackColor = Color.Blue;


        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxb.Text;
            string password = passwordtxb.Text;
            string email = emailtxb.Text;


            AdminManager manager = new AdminManager(new EfAdminDAL());
            manager.Add(new Admin()
            {
                Name = username,
                Mail = email,
                Passw = password

            });

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }




        private void Register_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Headerpnl_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Headerpnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Headerpnl_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Headerpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contentpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernametxb_TextChanged(object sender, EventArgs e)
        {
            usernamepnl.BackColor = Color.Blue;
        }

        private void passwordtxb_TextChanged_1(object sender, EventArgs e)
        {
            passwordpnl.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Login login = new Forms.Login();
            login.Show();
            this.Hide();
        }
    }
}