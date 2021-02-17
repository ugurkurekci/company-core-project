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

namespace WinForms.Forms.Authorized
{
    public partial class AuthorizedAddForm : Form
    {
        public AuthorizedAddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorizedManager manager = new AuthorizedManager(new EfAuthorizedDAL());
                var result = manager.Add(new Entities.Concrete.Authorized
                {
                    AuthorizedName = nametxb.Text,
                    AuthorizedSurname = surnametxb.Text,
                    AuthorizedSalary = Convert.ToInt32(salarytxb.Text),
                    AuthorizedDateofStart = Convert.ToInt32(dateofstarttxb.Text),
                    AuthorizedDateofOut = Convert.ToInt32(dateofouttxb.Text)

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AuthorizedAddForm form = new AuthorizedAddForm();
            this.Hide();
            form.Close();

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

        private void headerpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
