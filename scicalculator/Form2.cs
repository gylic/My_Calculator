using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scicalculator
{
    public partial class Form2 : Form
    {
        double  year = 0;
        double dm = 0;
        double rate = 0;
        double ma = 0;
        double lx = 0;
        double rt = 0;
        int flag = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (wb1.Text.Length == 0 || wb2.Text.Length == 0 || wb3.Text.Length == 0)
                return;

            year = double.Parse(wb1.Text);
            dm = double.Parse(wb2.Text);
            rate = double.Parse(wb3.Text);
  
         
            if(flag==0)//等额本息
            {
                double a=dm * 10000 * (rate / 100) * Math.Pow((1 + rate / 100), year * 12);
                ma = a / (Math.Pow((1 + rate / 100), year * 12) - 1);
                lx = year * 12 * ma - dm * 10000;
                rt = ma * year * 12;
                wb4.Text = ma.ToString ();
                wb5.Text = lx.ToString();
                wb6.Text = rt .ToString();

            }

            else //等额本金flag==1
            {
               
                lx= (dm * 10000 / (year * 12) + dm * 10000 * (rate / 100) + dm * 10000 / (year * 12) * (1 + rate / 100)) / 2 * (year * 12) - dm * 10000;
                rt = dm*10000+lx ;
                ma = rt / (year * 12);
                wb4.Text = ma.ToString();
                wb5.Text = lx.ToString();
                wb6.Text = rt.ToString();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            wb1.Text = "";
            wb2.Text = "";
            wb3.Text = "";
            wb4.Text = "";
            wb5.Text = "";
            wb6.Text = "";

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
