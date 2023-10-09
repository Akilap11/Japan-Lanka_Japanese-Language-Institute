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
    public partial class StaffLoginForm : Form
    {
        public StaffLoginForm()
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

        private void label_Back_Click(object sender, EventArgs e)
        {
            // Create an instance of the StartingForm
            StartingForm startingForm = new StartingForm();

            // Show the StartingForm
            startingForm.Show();

            // Close or hide the current form as needed
            this.Close(); // or this.Hide() if you want to hide it
        }

        private void label_Back_MouseEnter(object sender, EventArgs e)
        {
            label_Back.ForeColor = Color.DeepPink;
        }

        private void label_Back_MouseLeave(object sender, EventArgs e)
        {
            label_Back.ForeColor = Color.DarkBlue;
        }

        private void Button_StaffLogin_Click(object sender, EventArgs e)
        {
            StaffDashboard ss=new StaffDashboard();
            ss.Show();
        }

        private void Button_StaffLogin_Click_1(object sender, EventArgs e)
        {
            StaffDashboard ss = new StaffDashboard();
            ss.Show();
            this.Hide();
        }
    }
}
