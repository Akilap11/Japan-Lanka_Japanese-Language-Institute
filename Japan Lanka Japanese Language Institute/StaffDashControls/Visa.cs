using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japan_Lanka_Japanese_Language_Institute.StaffDashControls
{
    public partial class Visa_Registration : UserControl
    {
        public Visa_Registration()
        {
            InitializeComponent();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void Visa_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.pdf;)|*.jpeg;*.gif;*.bpm;*.png;*.pdf;";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = Open.FileName;
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.pdf;)|*.jpeg;*.gif;*.bpm;*.png;*.pdf;";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = Open.FileName;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.pdf;)|*.jpeg;*.gif;*.bpm;*.png;*.pdf;";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = Open.FileName;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.pdf;)|*.jpeg;*.gif;*.bpm;*.png;*.pdf;";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = Open.FileName;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.pdf;)|*.jpeg;*.gif;*.bpm;*.png;*.pdf;";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = Open.FileName;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.pdf;)|*.jpeg;*.gif;*.bpm;*.png;*.pdf;";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = Open.FileName;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
    }
}
