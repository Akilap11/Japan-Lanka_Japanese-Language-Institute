using Guna.UI2.WinForms;
using Japan_Lanka_Japanese_Language_Institute.StaffDashControls;
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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            Course uc = new Course();
            addusercontrol(uc);
        }

        private void addusercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContener.Controls.Clear();
            panelContener.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Button_Course_Click_1(object sender, EventArgs e)
        {
            Course uc = new Course();
            addusercontrol(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button_Visa_Click(object sender, EventArgs e)
        {
            Visa_Registration uc = new Visa_Registration();
            addusercontrol(uc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffDBBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the StartingForm
            StaffLoginForm staffLoginForm = new StaffLoginForm();

            // Show the StartingForm
            staffLoginForm.Show();

            // Close or hide the current form as needed
            this.Close(); // or this.Hide() if you want to hide it
        }

        private void StaffDBBack_MouseEnter(object sender, EventArgs e)
        {
            StaffDBBack.ForeColor = Color.DeepPink;
        }

        private void StaffDBBack_MouseLeave(object sender, EventArgs e)
        {
            StaffDBBack.ForeColor = Color.White;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CourseMeterials uc=new CourseMeterials();
            addusercontrol(uc);
        }
    }
}
