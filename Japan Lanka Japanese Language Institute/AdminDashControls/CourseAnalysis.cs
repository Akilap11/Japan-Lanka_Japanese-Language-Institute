using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Japan_Lanka_Japanese_Language_Institute.StaffDashControls;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;

namespace Japan_Lanka_Japanese_Language_Institute.AdminDashControls
{
    public partial class CourseAnalysis : UserControl
    {

        public CourseAnalysis()
        {
            InitializeComponent();
        }

        void FillChartWithStoredProc()
        {
            string connectionString = "Data Source=SiCks-ROG-G14\\MSSQLSERVER01;Initial Catalog=final;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("CalculateClassCount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();

                chart1.DataSource = dt;
                chart1.Series["Enrollments"].XValueMember = "class";
                chart1.Series["Enrollments"].YValueMembers = "EnrollmentCount";
                chart1.Titles.Add("ANALYZE");
            }
        }

        private void CourseAnalysis_Load(object sender, EventArgs e)
        {
            
        }

        private void CourseAnalysis_Load_1(object sender, EventArgs e)
        {
            FillChartWithStoredProc();
        }
    }
}

