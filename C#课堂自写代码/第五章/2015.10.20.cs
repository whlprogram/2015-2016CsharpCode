using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //int sum = 0;

            //while (i <= 1000)
            //{
            //    sum = sum + i;
            //    ++i;
            //}
            //Console.WriteLine(sum);



            //int y;
            //int x = 1;
            //int total = 0;

            //while (x <= 10)
            //{
            //    y = x * x;
            //    Console.WriteLine(y);
            //    total = total+y;
            //    x++;
            //}
            //Console .WriteLine ("Total is {0}",total);

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = 1;
            //int c = 1;
            //while (c <= a)
            //{
            //    b = b * c;
            //    c++;
            //}
            //Console.WriteLine(b);


            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = 1;
            //while (a > 0)
            //{
            //    b = b * a;
            //    a = a - 1;
            //}
            //Console.WriteLine(b);



           


            int a = 1;

            int max = Convert.ToInt32(Console.ReadLine());
            while (a <= 9)
            {

                int c = Convert.ToInt32(Console.ReadLine());
                a++;
                if (max < c)

                    max = c;


            }
            Console.WriteLine(max);



        }
    }
}
