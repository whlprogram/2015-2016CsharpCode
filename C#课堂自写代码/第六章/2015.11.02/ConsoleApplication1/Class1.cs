using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public void F538_1()
        {
            int n = Convert.ToInt32(Console .ReadLine());
            int i = 1;
            double e = 1.0;
            double x = 1;
            while (i <= n)
            {
                x = x * (double)i;
                double sum = (double)1 / x;
                
                e = e + sum;
               
                ++i;
            }
            Console.WriteLine(e);
            Console.WriteLine(Math.E);
        }


        public void F538_2()
        {
            double n = Convert.ToDouble(Console.ReadLine());
            double i = 1;
            double e = 1;
            double x = 1;
            double j = 1;
            while (i<=n)
            {                                                         
                while (j <= i)
                {
                    x = x * j;
                    ++j;
                }
                e = e + (double)1 / x;
                ++i;                             
            }
            Console.WriteLine(e);
            Console.WriteLine(Math.E);
            
        }


        public void F1()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void F2()
        {
            int i = 1;
            for (; i <= 10; )
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void F3()
        {         
            for (int i = 1; i <= 10;i++)
                Console.WriteLine(i);              
           
        }
        public void F4()
        {
            int i = 1;
            for (; i <= 10; i++)
                Console.WriteLine(i);

        }


        public void F5()
        {
            int sum = 0;
            for (int i=1;i <=1000;i=i+2)
                sum = sum + i;                   
                Console.WriteLine(sum);
        }

        public void F6()
        {
            int total = 0;
            for (int number = 1; number <= 1000; number += 2)
                total += number;
            Console.WriteLine("sum={0}", total);

        }


        public void F7()       //142页
        {
            decimal amount;
            decimal principal=1000;
            double rate = 0.05;
            Console.WriteLine("year{0,20}","Amount on deposit");

            for (int year = 1; year <= 100; ++year)
            {
                amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
                Console.WriteLine("{0,4}{1,20:c}", year, amount);
            }
        }

        public void F8()       //指数运算
        {
            decimal a;
            double rate = 2;
            a = 2 * ((decimal)Math.Pow(1.0 + rate, 2));
            Console.WriteLine(a);
        }

        public void F9()    //163页6.10题
        {
           
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 5; j++)
                        Console.Write("@");
                    Console.WriteLine();
                }
              
        }


        public void F10()   //165页6.26题for循环
        {
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= 3; ++j)
                {
                    for (int k = 1; k <= 4; ++k)
                        Console.WriteLine("*");

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }


        public void F11()     //165页6.26题while循环
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 3)
                {
                    int k = 1;
                    while (k <= 4)
                    {
                        Console.WriteLine("*");
                        ++k;
                    }
                    ++j;
                    Console.WriteLine();
                }
                ++i;
                Console.WriteLine();
            }
        }


        public void F12()    //164页6.15题a
        {          
                for (int n = 1; n<= 10; ++n)
                {
                    for (int k = 1; k <= n; ++k)
                        Console.Write("*");

                    Console.WriteLine();
                }                 
        }

        public void F13()       //164页6.15题b1
        {
            for (int n = 10; n >= 0; --n)
            {
                for (int k = 1; k <= n; ++k)
                    Console.Write("*");
                Console.WriteLine();
            }
        }


        public void F14()         //164页6.15题b2
        {
            for (int n = 1; n <= 10; ++n)
            {
                for (int k = 1; k <=11-n; ++k)
                    Console.Write("*");
                Console.WriteLine();
            }
        }



        public void F15()    //164页6.15题c1
        {
            for (int n = 1; n <= 10; ++n)
            {
                for (int k = 1; k <= 10; ++k)
                {
                    if (k < n )
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                    Console.WriteLine();
            }
        }




        public void F16()    //164页6.15题c2
        {
            for (int n = 1; n <= 10; ++n)
            {
                for (int k = 1; k <= n-1; ++k)              
                        Console.Write(" ");
                for (int k = 1; k <=11-n; ++k)
                        Console.Write("*");
               
                Console.WriteLine();
            }
        }


        public void F17()    //164页6.15题d
        {
            for (int n = 1; n <= 10; ++n)
            {
                for (int k = 1; k <= 10; ++k)
                {
                    if (k <= 10-n)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }





        public void F18()   //164页6.15题拓展  四个图形连一块
        {
            for (int j = 1; j <= 10; ++j)
            {
                for (int k = 1; k <= j; ++k)
                    Console.Write("*");
                for (int k = 1; k <=10-j; ++k)
                    Console.Write(" ");


                for (int l = 1; l <= 11 - j; ++l)
                    Console.Write("*");
                for (int l = 1; l <  j; ++l)
                    Console.Write(" ");

                for (int m = 1; m <= j - 1; ++m)
                    Console.Write(" ");
                for (int m = 1; m <= 11 - j; ++m)
                    Console.Write("*");

                for (int n = 1; n <= 10 - j; ++n)
                    Console.Write(" ");
                for (int n = 1; n <= j; ++n)
                    Console.Write("*");
               

                Console.WriteLine();
            }     
        }

        public void F19()
        { 
        }







    }
}
