using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        //静态方法在类的外部通过类的名字加点的方式来访问  例如：Class1.F1();
        //public static void F1()


        //非静态方法在类的外部通过对象的名字加点的方式来访问  例如：c.F1();
        //public void F1()





        public void F1()   //a+aa+aaa+aaaa.....
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            int z = F2(a, n); 
        
            Console .WriteLine(z);
        }
        public int  F2(int x,int y)
        {
            int sum = 0;
            int f = 0;
            for (int i = 1; i <= y; i++)
            {
                f = f * 10 + x;
                sum += f;
            }
                return sum;
        }


        public void F3()   //完数7.24
        {
            for (int i = 2; i <= 1000; i++)
            {              
                int z = F4(i);
                if ( z==0)
                    Console .WriteLine (z);
            }
        }
        public int   F4(int x)
        {
            int sum = 0;
            for (int m = 1; m < x; m++)
            {
                if (x % m == 0)
                    sum += m;
            }
            if (sum == x)
                return 0;
            return -1 ;
        }


        public void f5()
        {
            for (int i = 2; i <= 1000; i++)
            {
                int a = f6(i);
                if (a==i)
                Console.WriteLine(i);
            }
        }
        public int f6(int i)
        {
            int sum = 0;
            for (int a = 1; a < i; a++)
            {
                if (i % a == 0)
                    sum = sum + a;
            }
            return sum;
        }


        public void F7()  //找出1000以内的素数 7.25
        {
            for (int n = 2; n <= 1000; n++)
            {
                int z = F8(n);
                if (z == 1)
                    Console.WriteLine(n);
               
            }
        }
        public int  F8(int x) 
        {
            
                int sum = 0;
                for (int a = 1; a < Math.Sqrt(x); a++)    //根号x表示方法
                {
                    if (x % a == 0)
                        sum = sum + a;
                }
                return sum;
            
        }



        public void F9()  //找出1000以内的素数 7.25
        {
            for (int n = 2; n <= 1000; n++)
            {
                bool  z = F10(n);
                if (z == true)
                    Console.WriteLine(n);

            }
        }
        public bool  F10(int x)
        {

            for (int a = 2; a < Math.Sqrt(x); a++)   
            {
                if (x % a == 0)
                    return false   ;
            }
            return true;

        }
    }
}
