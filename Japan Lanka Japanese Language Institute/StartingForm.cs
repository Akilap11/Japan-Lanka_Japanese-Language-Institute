using System;
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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
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
            label_Exit.ForeColor = Color.DarkBlue;
        }

        private void Button_Staff_Click(object sender, EventArgs e)
        {
            // Create an instance of the StaffLoginForm
            StaffLoginForm staffLoginForm = new StaffLoginForm();

            // Show the StaffLoginForm
            staffLoginForm.Show();

            // Optionally, you can hide the current form if you want to close it when opening the new form
            this.Hide();
        }

        private void Button_Admin_Click(object sender, EventArgs e)
        {
            // Create an instance of the StaffLoginForm
            AdminLoginForm adminLoginForm = new AdminLoginForm();

            // Show the StaffLoginForm
            adminLoginForm.Show();

            // Optionally, you can hide the current form if you want to close it when opening the new form
            this.Hide();
        }
    }
}
