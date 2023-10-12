using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Japan_Lanka_Japanese_Language_Institute.StaffDashControls
{
    
    public partial class Course : UserControl
    {
        string selectedgender;
        string al; 
        public Course()
        {
            InitializeComponent();
        }
        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;)|*.jpeg;*.gif;*.bpm;*.png;";
            if(Open.ShowDialog() == DialogResult.OK) 
            {
                textBox7.Text = Open.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fullname = textBox1.Text;
            String dob = dateTimePicker1.Text;
            String Age = textBox3.Text;
            String address = textBox4.Text;
            String email = textBox5.Text;
            String nic = textBox6.Text;
            String classes = comboBox1.Text;
            string alvel = al;
            String gender = selectedgender;
            String ambassador = textBox2.Text;

          
            // Replace these connection string and query with your actual database details.
            string connectionString = "";
            string insertQuery = "INSERT INTO YourTable (Fullname, DOB, Age, Gender, Address, Email, NIC, Classes, AL, Ambassador) " +
                                "VALUES (@Fullname, @DOB, @Age, @Gender, @Address, @Email, @NIC, @Classes, @AL, @Ambassador)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Fullname", fullname);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@NIC", nic);
                    cmd.Parameters.AddWithValue("@Classes", classes);
                    cmd.Parameters.AddWithValue("@AL", alvel);
                    cmd.Parameters.AddWithValue("@Ambassador", ambassador);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Data insertion failed.");
                    }
                }
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                 selectedgender = "Male";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                 selectedgender = "Female";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                al = "Yes";
            }
            else
            {
                al = "No";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                al = "NO";
            }
            else
            {
                al = "No";
            }
        }
    }
}
