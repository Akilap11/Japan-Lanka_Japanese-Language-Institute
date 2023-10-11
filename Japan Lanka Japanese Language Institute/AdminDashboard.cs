﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japan_Lanka_Japanese_Language_Institute
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AdminDBBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the StartingForm
            AdminLoginForm adminLoginForm = new AdminLoginForm();

            // Show the StartingForm
            adminLoginForm.Show();

            // Close or hide the current form as needed
            this.Close(); // or this.Hide() if you want to hide it
        }

        private void AdminDBBack_MouseEnter(object sender, EventArgs e)
        {
            AdminDBBack.ForeColor = Color.Red;
        }

        private void AdminDBBack_MouseLeave(object sender, EventArgs e)
        {
            AdminDBBack.ForeColor = Color.DarkBlue;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Exit_MouseEnter(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Red;
        }

        private void label_Exit_MouseLeave(object sender, EventArgs e)
        {
            label_Exit.ForeColor= Color.DarkBlue;
        }
    }
}
