using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class SampleApp3 : Form
    {
        public SampleApp3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            int result;
            a = 10;
            b = 20;
            c = 30;
            d = 20;
            result = (a + b) * (c+d);
            MessageBox.Show(result.ToString());
            result = a + b * c+d;
            MessageBox.Show(result.ToString());

        }
    }
}
