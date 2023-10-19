using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Japan_Lanka_Japanese_Language_Institute.AdminDashControls
{
    public partial class StaffControll : UserControl
    {
        //CONNECTION
        private string connectionString = "Data Source=SiCks-ROG-G14\\MSSQLSERVER01;Initial Catalog=JapanLanka;Integrated Security=True";

        public StaffControll()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String stid = textBox6.Text;
            String password = textBox7.Text;
            String name = textBox1.Text;
            String mobile_no = textBox2.Text;
            String address = textBox3.Text;
            String nic = textBox4.Text;

            //INSERT QUERY
            string insertQuery = "insert into staff (stid,password,name,mobile_no,address,nic) values (@STID,@PASSWORD,@NAME,@MOBILE_NO,@ADDRESS,@NIC)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@STID", stid);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    cmd.Parameters.AddWithValue("@NAME", name);
                    cmd.Parameters.AddWithValue("@MOBILE_NO", mobile_no);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    //CONSOLE MESSAGE
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted successfully");
                        MessageBox.Show("Data inserted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Data insertion failed");
                        MessageBox.Show("Data insertion failed");
                    }

                }
            }
            //CLEAR TEXTBOXES
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();

            //UPDATE GRIDVIEW WHEN SUBMIT CLICKS
            UpdateDataGridView();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //CLEAR TEXTBOXES
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }


        private void StaffControll_Load_1(object sender, EventArgs e)
        {
            //UPDATE GRIDVIEW WHEN STAFF CONTROL LOADS
            UpdateDataGridView();
            
        }
        private void UpdateDataGridView()
        {
            string selectQuery = "SELECT stid, password, name, mobile_no, address, nic FROM staff";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // REVERSE ROW ORDER IN GRIDVIEW
                        DataTable reversedTable = dataTable.AsEnumerable().Reverse().CopyToDataTable();

                        dataGridView1.DataSource = reversedTable;
                    }
                }
            }
        }
    }

}
