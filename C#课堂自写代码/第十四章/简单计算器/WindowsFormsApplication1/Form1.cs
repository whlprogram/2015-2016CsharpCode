using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string num1 = "";
        string num2 = "";

        bool t = true;
        bool [] array = new bool[4];                    

        private void button1_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "1";
                textBox1.Text = num1;
            }
            else 
            {
                num2 += "1";
                textBox1.Text = num2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "2";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "2";
                textBox1.Text = num2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "3";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "3";
                textBox1.Text = num2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "4";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "4";
                textBox1.Text = num2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "5";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "5";
                textBox1.Text = num2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "6";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "6";
                textBox1.Text = num2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "7";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "7";
                textBox1.Text = num2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "8";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "8";
                textBox1.Text = num2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "9";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "9";
                textBox1.Text = num2;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += "0";
                textBox1.Text = num1;
            }
            else
            {
                num2 += "0";
                textBox1.Text = num2;
            }
        }

        private void buttonDian_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 += ".";
                textBox1.Text = num1;
            }
            else
            {
                num2 += ".";
                textBox1.Text = num2;
            }
        }

        private void addition_Click(object sender, EventArgs e)
        {
            t = false;
            array[0] = false;
            array[1] = true;
            array[2] = true;
            array[3] = true;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            t = false;
            array[0] = true;
            array[1] = false;
            array[2] = true;
            array[3] = true;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            t = false;
            array[0] = true;
            array[1] = true;
            array[2] = false;
            array[3] = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            t = false;
            array[0] = true;
            array[1] = true;
            array[2] = true;
            array[3] = false;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < 4; i++)
                {
                    if (array[0] != true)
                    {
                        textBox1.Text = "R=" + Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num2));
                    }
                    if (array[1] != true)
                    {
                        textBox1.Text = "R=" + Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                    }
                    if (array[2] != true)
                    {
                        textBox1.Text = "R=" + Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num2));
                    }
                    if (array[3] != true)
                    {
                        textBox1.Text = "R=" + Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                    }
                }
                num1 = "";
                num2 = "";
                for (int i = 0; i < 4; i++)
                    array[i]=true;
                t = true;
            }
            catch
            {
                MessageBox.Show("客官，点击不符合规则，重新点一下可好？");
            }
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            textBox1.Text = num1;
            for (int i = 0; i < 4; i++)
                array[i] = true;
            t = true;
        }

        private void aNumClear_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 = "";
                textBox1.Text = num1;
                t = true;
                for (int i = 0; i < 4; i++)
                    array[i] = true;
            }
            else
            {
                num2 = "";
                textBox1.Text = num2;
            }

        }

        private void BeforeClear_Click(object sender, EventArgs e)
        {
            if (t)
            {
                num1 = num1.Substring(0, num1.Length - 1);
                textBox1.Text = num1;
            }
            try
            {
                if (t == false && num2 != "")
                {
                    num2 = num2.Substring(0, num2.Length - 1);
                    textBox1.Text = num2;
                }
            }
            catch
            {
                MessageBox.Show("客官，点击不符合规则，重新点一下可好？");
            }
            if (t == false && num2 == "")
            {
                t = true;
            }
        }
    
    }
}
