using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms.Forms.Authorized
{
    public partial class AuthorizedForm : Form
    {
        public AuthorizedForm()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            AuthorizedAddForm form = new AuthorizedAddForm();
            form.Show();
            this.Hide();
        }



        private void openlistbtn_Click_1(object sender, EventArgs e)
        {
            AuthorizedDataForm form = new AuthorizedDataForm();
            form.Show();
            this.Hide();
        }

    }
}
