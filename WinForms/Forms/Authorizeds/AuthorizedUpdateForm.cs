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

namespace WinForms.Forms.Authorizeds
{
    public partial class AuthorizedUpdateForm : Form
    {
        public AuthorizedUpdateForm()
        {
            InitializeComponent();
        }

        private void exitpng_Click(object sender, EventArgs e)
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
                AuthorizedManager manager = new AuthorizedManager(new EfAuthorizedDAL());
                manager.Update(new Entities.Concrete.Authorized
                {
                    AuthorizedName = nametxb.Text,
                    AuthorizedSurname = surnametxb.Text,
                    AuthorizedSalary = Convert.ToInt32(salarytxb.Text),
                    IdentificationNumber = Convert.ToInt32(notxb.Text),
                    AuthorizedDateofStart = Convert.ToInt32(dateofstarttxb.Text),
                    AuthorizedDateofOut = Convert.ToInt32(dateofouttxb.Text)
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
        public string no, name, surname, salary, datestart, dateout;

        private void AuthorizedUpdateForm_Load(object sender, EventArgs e)
        {
            notxb.Text = no;
            nametxb.Text = name;
            surnametxb.Text = surname;
            salarytxb.Text = salary;
            dateofstarttxb.Text = datestart;
            dateofouttxb.Text = dateout;
        }
    }
}
