using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {

        double num=0,numi,calculate,final;
        string arthmetic;
        public Form1()
     
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if(textBox1.Text != ""){ 
            if (num == 0)
            {
                num = Convert.ToDouble(textBox1.Text);
                textBox1.Text = num.ToString();
                textBox1.Clear();
                arthmetic = "+";
            }
            else if (num != 0)
            {

                calculate = Convert.ToDouble(textBox1.Text);
                textBox1.Text = calculate.ToString();

                num = num + calculate;


                label1.Text = num.ToString();
                num = double.Parse(label1.Text);

                
            }
            textBox1.Clear();
            }
        }

        




        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if(textBox1.Text != "") { 
            numi = Convert.ToDouble(textBox1.Text);
            textBox1.Text = numi.ToString();
            calculate = 0;
            if (arthmetic == "+")
            {
                calculate = num + numi;
            }
            if (arthmetic == "-")
            {

                calculate = num - numi;

            }
            if (arthmetic == "*")
            {

                calculate = num * numi;

            }
            if (arthmetic == "/")
            {
                calculate = num / numi;

            }
            label1.Text = calculate.ToString();
            calculate = double.Parse(label1.Text);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text =="" && textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if(textBox1.Text != "") { 
            if (num == 0) { 
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = num.ToString();
            textBox1.Clear();
            arthmetic = "-";
            }
            else if(num != 0)
            {
                calculate = Convert.ToDouble(textBox1.Text);
                textBox1.Text = calculate.ToString();

                num = num - calculate;

                label1.Text = num.ToString();
                num = double.Parse(label1.Text);
                
            }
            textBox1.Clear();
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text =="" && textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            if(textBox1.Text != "") { 
            if (num == 0) { 
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = num.ToString();
            textBox1.Clear();
            arthmetic = "*";
            } else if(num != 0){
                calculate = Convert.ToDouble(textBox1.Text);
                textBox1.Text = calculate.ToString();

                num = num * calculate;

                label1.Text = num.ToString();
                num = double.Parse(label1.Text);
            }
            textBox1.Clear();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            num = 0;
            label1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") { 
            textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if(textBox1.Text != "") { 
            if (num == 0) { 
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = num.ToString();
            textBox1.Clear();
            arthmetic = "/";
            }else if (num != 0)
            {
                calculate = Convert.ToDouble(textBox1.Text);
                textBox1.Text = calculate.ToString();

                num = num / calculate;

                label1.Text = num.ToString();
                num = double.Parse(label1.Text);
            }
            textBox1.Clear();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        
    }
}
