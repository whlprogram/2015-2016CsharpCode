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
           int  n=1;
           while (n <= 10)
               Console.WriteLine(n++);
        }

        public void F2()
        {

            for (int n = 1; n <= 500; n++)
                for (int l = 1; l <= n; l++)
                    for (int m = 1; m <= l; m++)
                    {
                        if (n * n == l * l + m * m)
                            Console.WriteLine("{0}\t{1}\t{2}",m,l,n);
                    }
        }



        public void F3()    //a+aa+aaa+aaaa.....
        {
            int a = Convert.ToInt32(Console .ReadLine());
            int n = Convert.ToInt32(Console .ReadLine());
            int sum = 0;
            int t = 0;

            for (int i = 1; i <= n; i++)
            {
                t = t * 10 + a;
                sum = sum + t;
                
            }
            Console.WriteLine(sum );
        }


        public void F4()    //203页7.24   for循环
        {

            for (int i = 2; i <= 1000; i++)
            {
                int sum = 0;
                for (int m = 1; m < i; m++)
                {
                    if (i % m == 0)
                        sum += m;
                }

                if (sum == i)
                    Console.WriteLine(i);
            }
        }


        public void F5()     //203页7.25   for循环  判断是否为素数并输出小于10000的素数
        {
            for (int i = 2; i < 10000; i++)
            {
                int sum = 0;
                for (int m = 1; m < i; m++)   //m的上限是根号i
                {
                    if (i % m == 0)
                        sum += m;
                }

                if (sum == 1)
                    Console.WriteLine(i);
            }
        }
        public void F6()        //布尔类型
        {
            for (int i = 2; i < 10000; i++)
            {
               bool  sum = true ;
                for (int m = 1; m < i; m++)   
                {
                    if (i % m == 0)
                        sum = false ;
                }

                if (sum == true  )
                    Console.WriteLine(i);
            }
        }


        public void F7()     //203页7.25   for循环  最多用n的平方次判断是否为素数
        {  

        }

        public void F8()     //203页7.26
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b=0;
            int c=0;
            while (a > 0)
            {
                b = a % 10;
                c = c * 10 + b;                
                a = a / 10;
            }
            Console.WriteLine(c);
        }

        public void F9()     //203页7.27  求两个数最大公约数    反复相除
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            while (c > 0)
            {
                c = m % n;
                m = n;
                n = c;
            }
            Console.WriteLine(n);
        }

        public void F10()     //203页7.27
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());       
            while (n > 0)
            {
                int c = m % n;
                m = n;
                n = c;
            }
            Console.WriteLine(m);
        }






    }
}
