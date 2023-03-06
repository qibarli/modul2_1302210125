using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302210125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text[label1.Text.Length - 2] != '+')
            {
                label1.Text = label1.Text + " + ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int digitA = 0, intho1d = 0;
            int digitR;
            for(digitR = 0; digitR < label1.Text.Length; digitR++)
            {
                if (label1.Text[digitR] == ' ')
                {
                    intho1d += int.Parse(label1.Text.Substring(digitA, digitR));
                    digitA = digitR + 3;
                    digitR += 3;
                }
            }

            label1.Text = intho1d.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
