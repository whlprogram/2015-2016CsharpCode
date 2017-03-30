using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public class GradeBook
        {
            public string CourseName { get; set; }

            public GradeBook(string name)
            {
                CourseName = name;
            }

            public void DisplayMessage()
            {
                Console.WriteLine("Welcome to the grade book for\n {0}!\n ",CourseName);
            }

            public void DetermineClassAvreage()
            {
                int total;
                int gradeCounter;
                int grade;
                double average;

                total = 0;
                gradeCounter = 0;

                Console.WriteLine("Enter grade or -1 to quit:");
                grade = Convert.ToInt32(Console .ReadLine());

                while (grade != -1)
                {
                    total = total + grade;
                    gradeCounter = gradeCounter + 1;

                    Console.WriteLine("Enter grade or -1 to quit:");
                    grade = Convert.ToInt32(Console.ReadLine());

                }

                if (gradeCounter != 0)
                {
                    average = (double)total / gradeCounter;

                    Console.WriteLine("\nTotal of the {0} grades entered is {1}", gradeCounter, total);
                    Console.WriteLine("Class average is {0:F}", average);
                }
                else
                    Console.WriteLine("No grades were entered");
            }

        }






        public void F1()
        {
            Console.WriteLine("请输入一个五位数");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 10000 || n >= 100000)
            {
                Console.WriteLine("请重新输入");
                int m = Convert.ToInt32(Console.ReadLine());
                n = m;
            }
        }

        public void F2()  //回去学习一下！看书。
        {
        aaa:
            Console.WriteLine("请输入一个五位数字");
            int n = Convert.ToInt32(Console.ReadLine()); 
            if (n > 9999 && n < 100000)
                Console.Write("{0}", n);
            else
                goto aaa;

        }


        public void F3()
        {
            int c = 5;     //注意c++和++c的区别！
            //Console.WriteLine(c++);
            Console.WriteLine(++c);
            Console.WriteLine(c++);
            Console.WriteLine(++c);
            Console.WriteLine(c++);
        }

        public void F4()
        {
            Console.WriteLine("输入1或2");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 1 && a != 2)    //&&和||一定要用准确
            {
                Console.WriteLine("Invalid input");
                int b = Convert.ToInt32(Console.ReadLine());
                a = b;
            }
        }



        public void F5()   //第133页 5.29
        {
            int i = 1; 
            int j = 1;
                while (i<=10)
                {
                    j = 1;
                    while (j <= 10)
                    {
                        if ((i==1)||(i==10)||(j==1)||(j==10))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                        j++;    
                    }
                    i++;
                    Console.WriteLine();
                }
                       
        }

            
        

    }
}
