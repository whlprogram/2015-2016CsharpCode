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

namespace PONG
{
    public partial class Form1 : Form
    {       
        Random random = new Random();


        int[] ball_pos = { 285, 185 };      //定义球初始位置
        int[] ball_vel = { 0, 0 };          //定义球初始速度
        int[] pad1_pos = { 0, 170 };        //定义左球拍初始位置
        int[] pad2_pos = { 595, 170 };      //定义右球拍初始位置
        int pad_width = 5;                  //定义球拍宽度
        int pad_height = 60;                //定义球拍高度
        int pad1_vel = 0;                   //定义左球拍初始速度
        int pad2_vel = 0;                   //定义右球拍初始速度
        int time = 0;                       //定义初始游戏时间
        int Difficulty = 5;                 //定义游戏难度
   
        public Form1()
        {
            InitializeComponent();
        }

        public void F1(bool direction)   //控制发球方向
        {
            
            ball_pos[0] = 285;    //重新定义球的位置
            ball_pos[1] = 185;
            pictureBox1.Location = new Point(ball_pos[0], ball_pos[1]);

            ball_vel[0] = random.Next(Difficulty, Difficulty + 3);  //重新定义球的速度
            ball_vel[1] = random.Next(Difficulty, Difficulty + 3);
            if (direction == true)   //发球方向 左面
            {
                ball_vel[0] = -ball_vel[0];
                ball_vel[1] = -ball_vel[1];
            }
            else if (direction == false)  //发球方向 右面
                ball_vel[1] = -ball_vel[1];
        }       
        private void Game_Start_Click(object sender, EventArgs e) //开始游戏       
        {
            MessageBox.Show("游戏开始！");
            Game_Start.Enabled = false;     // 开始游戏按钮调整  没有可控性（开始按钮失效）
            domainUpDown1.Enabled = false;  // 难度调整  没有可控性         
            ball_vel[0] = random.Next(Difficulty, Difficulty + 3);
            ball_vel[1] = random.Next(Difficulty, Difficulty + 3);
            textBox1.Text = Convert.ToString(0);  //左方初始分数
            textBox2.Text = Convert.ToString(0);  //右方初始分数
            F1(false);

            
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e) //调整游戏难度
        {
            if (domainUpDown1.Text == "2")
            {
                Difficulty = 10;
            }
            else if (domainUpDown1.Text == "3")
            {
                Difficulty = 15;
            }
            else if (domainUpDown1.Text == "4")
            {
                Difficulty = 20;
            }
            else if (domainUpDown1.Text == "5")
            {
                Difficulty = 25;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //用计时器更新球的位置
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + ball_vel[0], pictureBox1.Location.Y + ball_vel[1]);                     
            panel1.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e) //用计时器更新游戏时间
        {           
            textBox3.Text = Convert.ToString(time);
            time += 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)   //画布
        {
            
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Black, 300, 0, 300, 400); //画中间拦网
            g.DrawRectangle(Pens.Red, pad1_pos[0], pad1_pos[1] + pad1_vel, pad_width, pad_height);  //画左球拍
            g.DrawRectangle(Pens.Red, pad2_pos[0], pad2_pos[1] + pad2_vel, pad_width, pad_height);  //画右球拍

            if ((pad1_pos[1] + pad1_vel > 0) && (pad1_pos[1] + pad1_vel < 340)) //更新左球拍的位置
            {
                pad1_pos[1] += pad1_vel;
            }
            if ((pad2_pos[1] + pad2_vel > 0) && (pad2_pos[1] + pad2_vel < 340)) //更新右球拍的位置
            {
                pad2_pos[1] += pad2_vel;
            }

            

            //更新球的位置
            ball_pos[0] = pictureBox1.Location.X;
            ball_pos[1] = pictureBox1.Location.Y;
            ball_pos[0] += ball_vel[0];
            ball_pos[1] += ball_vel[1];



            //判断球在左边框是否反弹
            if (ball_pos[0] <= pad_width)
            {
                if ((pad1_pos[1] <= ball_pos[1] + pictureBox1.Height / 2) && (pad1_pos[1] + pad_height >= ball_pos[1] + pictureBox1.Height / 2))
                {
                    ball_vel[0] = -ball_vel[0];      //令反弹后的球速度方向改变
                    ball_vel[0] = ball_vel[0] + 5;   //令反弹后的球速度增加
                    ball_vel[1] = ball_vel[1] + 5;   //令反弹后的球速度增加
                    ball_pos[0] += ball_vel[0];      
                    ball_pos[1] += ball_vel[1];
                }
                else
                {
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + 1);  //令右方得分
                    F1(false);  //左方发球
                }
            }
            //判断球在右边框是否反弹
            if (ball_pos[0] >= 571 - pad_width) //601是panel的宽度 30为pictureBox1宽度 601-30=571
            {
                if ((pad2_pos[1] <= ball_pos[1] + pictureBox1.Height / 2) && (pad2_pos[1] + pad_height >= ball_pos[1] + pictureBox1.Height / 2))
                {
                    ball_vel[0] = -ball_vel[0];     //令反弹后的球速度方向改变
                    ball_vel[0] = ball_vel[0] + 5;  //令反弹后的球速度增加
                    ball_vel[1] = ball_vel[1] + 5;  //令反弹后的球速度增加
                    ball_pos[0] += ball_vel[0];
                    ball_pos[1] += ball_vel[1];
                }
                else
                {
                    textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 1);  //令左方得分
                    F1(true);   //右方发球
                }
            }
            //令球在上下边框反弹
            if ((ball_pos[1] <= 0) || (ball_pos[1] >= 400 - pictureBox1.Height))
            {               
                    ball_vel[1] = -ball_vel[1];                             
            }
            
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)   //上下键和 W S键  控制球拍移动
        {
            int acc = 10;
            if (e.KeyCode == Keys.W)
            {
                pad1_vel = -acc;
            }
            if (e.KeyCode == Keys.S)
            {
                pad1_vel = acc;
            }          
            if (e.KeyCode == Keys.O)
            {
                pad2_vel = -acc;
            }
            if (e.KeyCode == Keys.K)
            {
                pad2_vel = acc;
            }         
            panel1.Refresh();  //重画panel1面板                    
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)  //KeyPress事件 发生在KeyDown和KeyUp之间
        {
            //int acc = 10;
            //if (e.KeyChar.ToString() == Keys.W.ToString())
            //{
            //    pad1_vel = -acc;
            //}
            //if (e.KeyChar.ToString() == Keys.S.ToString())
            //{
            //    pad1_vel = acc;
            //}
            //if (e.KeyChar.ToString() == Keys.Up.ToString())
            //{
            //    pad2_vel = -acc;
            //}
            //if (e.KeyChar.ToString() == Keys.Down.ToString())
            //{
            //    pad2_vel = acc;
            //}
            //panel1.Refresh();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pad1_vel = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                pad1_vel = 0;
            }
            if (e.KeyCode == Keys.O)
            {
                pad2_vel = 0;
            }
            if (e.KeyCode == Keys.K)
            {
                pad2_vel = 0;
            }        
            panel1.Refresh();
        }

        private void Game_Over_Click(object sender, EventArgs e) //结束游戏
        {
            if (MessageBox.Show("确定要结束游戏？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
           
        
    }
}
