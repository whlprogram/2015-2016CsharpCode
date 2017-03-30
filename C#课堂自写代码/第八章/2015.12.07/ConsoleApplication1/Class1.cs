using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public void F1()  //求数组中最大值,次大值,最小值和次小值
        {
            int[] A = { 60, 7, 86, 9, 0, 81, 2, 33, 4, 51 };
            int n=0;
            int max1 = A[n], max2 = A[n + 1];
            for (int i = 1; i < A.Length-1; i++)
            {
                if (max1 < max2)
                {
                    max1 = A[n + 1];
                    max2 = A[n];
                }
                if (A[n + 2] >= max1)
                {
                    max2 = max1;
                    max1 = A[n + 2];
                }
                if (A[n + 2] < max1&&A[n + 2] > max2)
                    max2 = A[n + 2];           
                ++n;
            }
            n = 0;  
            int min1 = A[n], min2 = A[n + 1];
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (min1 > min2)
                {
                    min1 = A[n + 1];
                    min2 = A[n];
                }
                if (A[n + 2] <= min1)
                {
                    min2 = min1;
                    min1 = A[n + 2];
                }
                if (A[n + 2] > min1 && A[n + 2] < min2)
                    min2 = A[n + 2];
                ++n;
            }
            Console.WriteLine("数组最大值是{0}",max1);
            Console.WriteLine("数组次大值是{0}",max2);
            Console.WriteLine("数组最小值是{0}",min1);
            Console.WriteLine("数组次小值是{0}",min2);
        }
        public void F2()    //求数列1,1,2,3,5,8.......的前五十项的值，并求和
        {
            double[] a = new double[50];   //可以用decimal代替double，不可以用int，sum超出了范围
            double sum = 0;
            a[0] = 1;
            a[1] = 1;
            for (int b = 2; b < 50; b++)
                a[b] = a[b - 1] + a[b - 2];
            for (int c = 0; c < 50; c++)
            {
                Console.WriteLine(a[c]);
                sum += a[c];
            }
            Console.WriteLine("sum  is {0}", sum);

        }



        public void F3()   //第244页8.12题   输入一个五个不同元素的集合并显示
        {
            int[] array = new int[5];   
         
                Console.Write("请输入10 - 100（含）的一个数:");
                int a = Convert.ToInt32(Console.ReadLine());             
                while (a <= 10 || a > 100)
                {                
                    Console.Write("请重新输入10 - 100（含）的一个数:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    a = c;
                }
                array[0] = a;       //将第一次符合条件的数赋值给数组的第一个元素
                for (int i = 1; i < 5; i++)   //输入剩余的4个元素
                {
                    Console.Write("请输入10 - 100（含）的一个数:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    while (b <= 10 || b > 100)
                    {
                        Console.Write("请重新输入10 - 100（含）的一个数:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        b = c;
                    }
                    for (int q = 0; q < i; q++)
                    {
                        if (array[q] != b)        //该元素不能与前面的几个元素重复
                            array[i] = b;
                        else
                        {
                            i--;
                            break;    //该元素与数组前面元素重复，增加一次输入数值的机会并跳出循环。
                        }
                    }

                }
            Console.WriteLine("{0}{1,10}","Index","Value");
            for (int m = 0; m < 5;m++ )
                Console.WriteLine("{0,5}{1,10}", m, array[m]);           
        }


        Random m = new Random();  //此句必须放在方法外，增大随机数生成间隔
        public void F4()  //第245页8.17题
        {
            int[] array = new int[11];    //生成含是一个元素的数组，默认值为0
            for (int n = 1; n <= 36000; n++)
            {
                int sum = 0;
                for (int i = 1; i <= 2; i++)
                {
                    int a = m.Next(1, 7);
                    sum += a;     //求掷一次骰子的和  
                }
                array[sum - 2]++;  //记每种和的次数
            }
            Console.WriteLine("和   次数");
            for (int counter = 2; counter <= 12; counter++)
            {
                Console.WriteLine("{0}   {1}", counter, (array[counter - 2]));   //counter代表和，数组array内元素为各种和的次数
            }
        }
    }
}
