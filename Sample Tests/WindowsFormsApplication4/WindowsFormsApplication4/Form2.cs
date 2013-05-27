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
    public partial class SampleApp2 : Form
    {
        public SampleApp2()
        {
            InitializeComponent();
        }

        private void SampleApp2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intVal;
            float fltVal;
            double dblVal;

            intVal = 1299/77;
            fltVal = 1299/77;
            dblVal = 1299.00 / 77.00;
            string strName;
            string strmsgname;
            strName = textBox1.Text;
            strmsgname = "Your Name is:";
            textBox2.Text = strmsgname + strName;
            label2.Text = strmsgname + strName;
            MessageBox.Show(strmsgname + strName);
            //MessageBox.Show(ToString(intVal) + ToString(fltVal) + ToString(dblVal));
            MessageBox.Show("IntVal:"+intVal.ToString()+" "+"Float Val:"+fltVal.ToString()+" "+"Double Val:"+dblVal.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
