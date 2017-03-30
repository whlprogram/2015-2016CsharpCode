using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Class1
    {
        public void F523()
        {
            int i = 1;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int max1 = a;
            int max2 = b;

            if (b > a)
            {
                max1 = b;
                max2 = a;
            }

            while (i <= 8)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > max1)
                { 
                    max2 = max1;
                    max1 = n;
                }
                else if (n > max2)
                    max2 = n;

                i++;
            }

            Console.WriteLine("{0}\t{1}", max1, max2);
        }



        public void F523_2()
        {
            int i = 1;
            int max1 = Convert.ToInt32(Console.ReadLine());
            int max2 = Convert.ToInt32(Console.ReadLine());

            if (max2 > max1)
            {
                int t = max1;
                max1 = max2;
                max2 = t;
            }

            while (i <= 8)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > max1)
                {
                    max2 = max1;
                    max1 = n;
                }
                else if (n > max2)
                    max2 = n;

                i++;
            }

            Console.WriteLine("{0}\t{1}", max1, max2);
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
            int i = Convert.ToInt32(Console.ReadLine());

            while (i != 0)
            {
                Console.WriteLine(i);
                i = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void F3()
        {
            int i = 1;

            while (i == 1)
            {
                Console.WriteLine(i);
                
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 10)
                    i = 2;
            }
        }


        public void F4()
        {
            int i = 1;
            int n = 0;

            while (i == 1)
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n >= 10000)
                    if(n<100000)
                        i = 2;
            }

            Console.WriteLine(n);
        }


        public void F5()
        {
            int c = 5;

            Console.WriteLine(c++);
            Console.WriteLine(++c);
            Console.WriteLine(c++);
            Console.WriteLine(++c);
        }


        public void F6()
        {
            int x = 1, total=0;

            while (x <= 10)
            {
                //total += x;
                total = total + x;
                ++x;
            }

            Console.WriteLine(total);
        }




        public void F7()
        {
            int i = 1;
            int n = 0;

            while (i == 1)
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                    i = 2;

                if (n == 2)
                    i = 2;

                if (i == 1)
                    Console.WriteLine("Invalid Input!");
            }

            Console.WriteLine(n);
        }



        public void F529()
        {
            int i = 1, j =1;
            int n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                j = 1;

                while (j <= n)
                {
                    if ((i == 1) || (i == n) || (j == 1) || (j == n))
                        Console.Write("*");
                    else
                        Console.Write(" ");

                    j++;
                }

                i++;
                Console.WriteLine();
            }
        }

        public void F5292()
        {
            int i = 1, j = 1;
            int n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                j = 1;

                while (j <= n)
                {
                    if ((i != 1) && (i != n) && (j != 1) && (j != n))
                        Console.Write(" ");
                    else
                        Console.Write("*");

                    j++;
                }

                i++;
                Console.WriteLine();
            }
        }







    }
}
