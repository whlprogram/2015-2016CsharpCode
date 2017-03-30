using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class1
    {
        //private enum Status {C,W,L }
        //C,W,L相当于三个常量，如果不赋值的话，有默认值，都是静态的
        //Status可以作为一个新的类型来使用，可以定义Status类的对象
        private enum Status { C=0,W=1,L=2}

        public void F()
        {
            Status S1 = Status.C;
            S1 = Status.W;
            S1 = Status.L;

            int i =(int )S1 ;
            Console.WriteLine(i );

            Console.WriteLine((int )Status .C );


        }
    }
}
