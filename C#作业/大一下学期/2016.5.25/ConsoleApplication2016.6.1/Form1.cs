using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApplication2016._6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private StreamWriter filewriter;
        private StreamReader filereader;

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog filechooser = new SaveFileDialog();
            DialogResult result = filechooser.ShowDialog(); //定义一个对话框result
            string filename = filechooser.FileName;        //定义一个字符串filename
            filechooser.CheckFileExists = false;
            if (result == DialogResult.OK)
            {
                if (filename == string.Empty)
                    MessageBox.Show("!!!!");
                else
                {
                    try
                    {
                        FileStream output = new FileStream(filename, FileMode.Create, FileAccess.Write);
                        filewriter = new StreamWriter(output);
                        save.Enabled = false;
                        write.Enabled = true;
                        read.Enabled = true;
                        next.Enabled = true;
                        exit.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("!!!!!");
                    }
                }
            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty)
                {
                    filewriter.WriteLine(textBox1.Text + ":");
                    filewriter.Flush();
                    textBox1.Clear();
                }
                else
                    MessageBox.Show("WriteWriteWriteWriteWrite");
            }
            catch (IOException)
            {
                MessageBox.Show("WriteWriteWriteWriteWrite");
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            OpenFileDialog filechooser = new OpenFileDialog();
            DialogResult result = filechooser.ShowDialog();  //定义一个对话框result
            string filename = filechooser.FileName;          //定义一个字符串filename
            if (result == DialogResult.OK)
            {
                textBox1.Clear();
                if (filename == string.Empty)
                    MessageBox.Show("ReadReadReadReadRead");
                else
                {
                    FileStream input = new FileStream(filename,FileMode.Open,FileAccess.Read);
                    filereader = new StreamReader(input);
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                string inputrecord = filereader.ReadLine();
                if (inputrecord != null)
                {
                    textBox1.Text = inputrecord;
                }
                else
                {
                    filereader.Close();
                    textBox1.Clear();
                    MessageBox.Show("nextnextnextnextnextnext");
                }
            }
            catch (IOException)
            {
                MessageBox.Show("NextNextNextNextNext");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (filewriter != null)
            {
                try
                {
                    filewriter.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("ExitExitExitExitExit");
                }
            }
            Application.Exit();
        }


    }
}
