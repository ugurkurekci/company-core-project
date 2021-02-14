using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }



        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
        CustomerRegistrationManager manager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());

        private void databaseshowbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manager.GetAll().Data;
            TotalLabel();

        }
        public void TotalLabel()
        {
            lblTotal.Text = $"TOTAL CUSTOMER :{dataGridView1.RowCount}";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {


            }
        }

        private void notxb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            notxb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            surnametxb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            telephonetxb.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailtxb.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            manager.Add(new Entities.Concrete.CustomerRegistration
            {
                NewCustomerName = nametxb.Text,
                NewCustomerSurname = surnametxb.Text
                ,
                NewCustomerTelephoneNo = Convert.ToInt32(telephonetxb.Text),
                Mail = emailtxb.Text
            });
            dataGridView1.DataSource = manager.GetAll().Data;
            TotalLabel();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            manager.Update(new Entities.Concrete.CustomerRegistration
            {
                NewCustomerId = Convert.ToInt32(notxb.Text),
                NewCustomerName = nametxb.Text,
                NewCustomerSurname = surnametxb.Text,
                NewCustomerTelephoneNo = Convert.ToInt32(telephonetxb.Text),
                Mail = emailtxb.Text
            }); ;
            dataGridView1.DataSource = manager.GetAll().Data;
            TotalLabel();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            manager.Delete(new Entities.Concrete.CustomerRegistration { NewCustomerId = Convert.ToInt32(notxb.Text) });
            dataGridView1.DataSource = manager.GetAll().Data;
            TotalLabel();
        }
    }
}
