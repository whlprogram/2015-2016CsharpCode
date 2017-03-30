using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {

        public void F1()   //164页6.15题拓展  四个图形连一块
        {
            for (int j = 1; j <= 10; ++j)
            {
                for (int k = 1; k <= j; ++k)
                    Console.Write("*");
                for (int k = 1; k <= 10 - j; ++k)
                    Console.Write(" ");


                for (int l = 1; l <= 11 - j; ++l)
                    Console.Write("*");
                for (int l = 1; l < j; ++l)
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

        public void F2()      //165页6.23题
        {
            for (int j = 1; j <= 5; ++j)
            {
                for (int k = 1; k <= 5-j; ++k)
                    Console.Write(" ");
                for (int k = 1; k <= 2*j-1; ++k)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int j = 1; j <= 4; ++j)
            {
                for (int k = 1; k <= j; ++k)
                    Console.Write(" ");
                for (int k = 1; k <= 9-j*2; ++k)
                    Console.Write("*");

                Console.WriteLine();
            }
        }



        public void F3()      //165页6.24题
        {

        }



        public void F4()      //do ... while
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }while (i >= 10);
            
                Console .WriteLine();                    
        }

        public void F5()      //switch语句
        {
            int n = Convert.ToInt32(Console .ReadLine());

            switch (n / 10)
            {
                case 9:     //表示9和10都运行下面的A，
                case 10:    //case后面只能跟常数，不能跟变量
                    Console.WriteLine("A");
                    break;    //break不能少
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default :
                    Console.WriteLine("F");
                    break;
            }
        }


        public void F6()
        {
 
        }


    }
}
