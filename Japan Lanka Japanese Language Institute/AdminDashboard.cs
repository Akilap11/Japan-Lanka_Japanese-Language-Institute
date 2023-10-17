using Japan_Lanka_Japanese_Language_Institute.AdminDashControls;
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            CourseAnalysis uc=new CourseAnalysis();
            addusercontrol(uc);
        }
        private void addusercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

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
            MarketingAnalysis uc=new MarketingAnalysis();
            addusercontrol(uc);
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

        private void button1_Click(object sender, EventArgs e)
        {
            CourseAnalysis uc = new CourseAnalysis();
            addusercontrol(uc);
        }

        private void Button_Visa_Click(object sender, EventArgs e)
        {
            VisaApprovels uc= new VisaApprovels();
            addusercontrol(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffControll uc=new StaffControll();
            addusercontrol(uc) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultAnalysis uc=new ResultAnalysis();
            addusercontrol(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FeedbackAnalysis uc=new FeedbackAnalysis();
            addusercontrol(uc);
        }
    }
}
