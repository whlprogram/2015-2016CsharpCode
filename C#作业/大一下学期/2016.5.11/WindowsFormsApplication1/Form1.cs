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
        public void F1()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("不允许为空");
                textBox1.Focus();
            }
            textBox2.Text = "textBox1字符串长度：" + textBox1.Text.Length + "\n";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                int cs = 0;
                char b = textBox1.Text[i];
                foreach (char c in textBox1.Text)
                {
                    if (c == b)
                        cs++;
                }
                textBox2.AppendText(textBox1.Text[i] + "出现的次数：" + cs + "\n");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                F1();
            }      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F1();
        }
    }
}
