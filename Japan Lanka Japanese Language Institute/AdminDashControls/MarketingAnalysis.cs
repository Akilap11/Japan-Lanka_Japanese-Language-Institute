using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japan_Lanka_Japanese_Language_Institute.AdminDashControls
{
    public partial class MarketingAnalysis : UserControl
    {
        List<String> XValues1 = new List<String>();
        List<int> YValues1 = new List<int>();

        List<String> XValues2 = new List<String>();
        List<int> YValues2 = new List<int>();

        List<String> XValues3 = new List<String>();
        List<int> YValues3 = new List<int>();

        public MarketingAnalysis()
        {
            InitializeComponent();
            XValues1.Add("Ambassador 1");
            YValues1.Add(42);

            XValues1.Add("Ambassador 2");
            YValues1.Add(61);

            XValues1.Add("Ambassador 3");
            YValues1.Add(50);

            XValues1.Add("Ambassador 4");
            YValues1.Add(40);

            XValues1.Add("Ambassador 5");
            YValues1.Add(52);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            chart1.Series["Enrollments"].Points.DataBindXY(XValues1, YValues1);
        }
    }
}
