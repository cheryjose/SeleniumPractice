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
    public partial class SampleApp4 : Form
    {
        public SampleApp4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intVal;
            float fltVal;
            double dblVal;
            string strVal;
            intVal=int.Parse(textBox2.Text);
            MessageBox.Show(intVal.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="int")
            {
                textBox1.Text = "int";         
            }
            else if (comboBox1.Text=="float")
            {
                textBox1.Text = "float";   
            }

            else if (comboBox1.Text=="double")
            {
                textBox1.Text = "double"; 
            }
            else if(comboBox1.Text=="string")
            {
                textBox1.Text = "string"; 
            }
        }

       
    }
}
