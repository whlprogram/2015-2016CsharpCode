using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
      
    class Class1
    {
        
        public void F1()
        {
            int i = 10;
            //数值类型作为参数传递的时候，传递的是数值，而不是内存地址
            F2(i);
            Console.WriteLine(i);//10
        }
        public void F2(int x)
        {
            x = 2 * x;
            Console.WriteLine(x);//20
        }


        private int j = 10;
        public void F3()
        {                      
            F4();
            Console.WriteLine(j);//20
        }
        public void F4()
        {
            j *= 2 ;
            Console.WriteLine(j);//20
        }



      
        public void F5()
        {
            int j = 10;
            //数值类型作为参数传递的时候，加上ref，则传递的是内存地址
            F6(ref  j);
            Console.WriteLine(j);//20
        }
        public void F6(ref  int x)
        {
            x = 2 * x;
            Console.WriteLine(x);//20
        }

        public void F7()  //202页7.17  判断整数的奇偶性
        {          
            Console.Write("请输入一个整数:");
            
            while (5 > 4)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                bool z = F8(a);
                Console.WriteLine(z);
                if (a < 0)
                    break;
            }
        }
        public bool F8(int  x)
        {
            int y = x % 2;
            if (y == 0)
                return true;
            else
                return false;
        }

        public void F9()  //202页7.18
        {
            Console.Write("请输入正方形边长:");
            int side = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= side; i++)
            {
                for (int j = 1; j <= side; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
