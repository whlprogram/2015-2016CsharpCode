using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public void F1()  //求数列和 1+1+2+3+5+8+13+..... （后一个数是前两个数的和）
        {
            int n = Convert.ToInt32(Console .ReadLine());
            int a = 0;
            int b = 1;
            int sum=0;
            for (int m = 1; m <= n; m++)
            {
                sum += b;               
                int c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(sum);

        }
    }
}
