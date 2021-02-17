using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForms.Forms.Authorizeds;

namespace WinForms.Forms.Authorized
{
    public partial class AuthorizedDataForm : Form
    {
        public AuthorizedDataForm()
        {
            InitializeComponent();
        }

        private void AuthorizedDataForm_Load(object sender, EventArgs e)
        {
            bringdatatolist();




        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clickbtn_Click(object sender, EventArgs e)
        {
            AuthorizedDeleteForm form = new AuthorizedDeleteForm();
            form.no = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.surname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.salary = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.datestart = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.dateout = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form.Show();


        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            bringdatatolist();
        }
        public void bringdatatolist()
        {
            AuthorizedManager manager = new AuthorizedManager(new EfAuthorizedDAL());
            dataGridView1.DataSource = manager.GetAll().Data;
            countlbl.Text = dataGridView1.Rows.Count.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            AuthorizedUpdateForm form = new AuthorizedUpdateForm();
            form.no = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.surname = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.salary = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.datestart = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.dateout = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form.Show();
        }
    }
}
