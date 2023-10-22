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
        private string connectionString = "Data Source=SiCks-ROG-G14\\MSSQLSERVER01;Initial Catalog=final;Integrated Security=True";
        public CourseAnalysis()
        {
            InitializeComponent();
        }

        void FillChartWithStoredProc()
        {
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

        private void PopulateComboBoxes()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT DISTINCT YEAR(row_created_at) AS Year FROM course ORDER BY Year DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear any existing items in comboBox1
                comboBox1.Items.Clear();

                while (reader.Read())
                {
                    int year = reader.GetInt32(reader.GetOrdinal("Year"));
                    comboBox1.Items.Add(year);
                }

                con.Close();
            }

            // Set the selected index to 0 (No default item)
            comboBox1.SelectedIndex = 0;
            UpdateComboBox2();
        }

        private void UpdateComboBox2()
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    if (comboBox1.SelectedItem is int selectedYear)
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            string query = $"SELECT DISTINCT MONTH(row_created_at) AS Month FROM course WHERE YEAR(row_created_at) = {selectedYear} ORDER BY Month DESC";
                            SqlCommand cmd = new SqlCommand(query, con);
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                int month = reader.GetInt32(reader.GetOrdinal("Month"));
                                comboBox2.Items.Add(month);
                            }

                            con.Close();
                        }
                    }
                }
            }

            comboBox2.SelectedIndex = 0;
        }

        private void CourseAnalysis_Load_1(object sender, EventArgs e)
        {
            FillChartWithStoredProc();
            PopulateComboBoxes();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBox2();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}