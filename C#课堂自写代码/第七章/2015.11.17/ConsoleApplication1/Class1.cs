using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public void F1() //掷骰子
        {
            Random r = new Random();
            Console.WriteLine(r.Next());
            Console.WriteLine(r.Next(100));
            Console.WriteLine(r.Next(10, 20));
        }

        public void F2()  //Random r = new Random();
        {                 //放在for循环里，每次运行时间间隔太短
                          //容易连续几次形成近似值，最好放在循环外。

            for (int i = 1; i <= 100; i++)
            {
                Random r = new Random();
                Console.WriteLine(r.Next(1, 7));
            }
        }

        public void F3()
        {
            Random r = new Random();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(r.Next(1, 7));
            }
        }

        public void F4()    //判断硬币正反。
        {
            Random r = new Random();
            int T=0;
            int F=0;
            int face;
            
            for (int i = 1; i <= 1000000; ++i)
            {
                face = r.Next(1, 3);
                switch (face)
                {
                    case 1:
                        ++T;
                        break;
                    case 2:
                        ++F;
                        break;
                }
            }
            Console.WriteLine("Face\t正反");
            Console.WriteLine("正\t{0}\n反\t{1}",T,F);
        }
    }
}
