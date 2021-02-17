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

namespace WinForms.Forms.AboutMe
{
    public partial class AboutMeForm : Form
    {
        public AboutMeForm()
        {
            InitializeComponent();
        }





        private void AboutMeForm_Load(object sender, EventArgs e)
        {
            AboutMeManager manager = new AboutMeManager(new EfAboutMeDAL());


            foreach (var item in manager.GetAll().Data)
            {
                namelbl.Text = item.Name;
                surnamelbl.Text = item.Surname;
                agelbl.Text = Convert.ToInt32(item.Age).ToString();
                linkedinlbl.Text = item.linkedin;
                joblbl.Text = item.Job;
                richTextBox1.Text = item.context;
                githublbl.Text = item.github;
                break;
            }




        }

        private void contextlbl_Click(object sender, EventArgs e)
        {

        }

        private void githublbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Process.Start("https://github.com/ugurkurekci");
        }

        private void linkedinlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/ugurkurekci");
        }

        private void surnamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
