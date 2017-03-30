using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class2
    {
        //定义在类中，但不属于方法，可以为私有或者公有，默认为私有的
        //实例变量的作用范围是整个类
        //实例变量可以在类的方法里进行调用
        //实例变量的值会被保存
        //实例变量如果没有初始化，会自动初始化为默认值.（数值为0，字符串为空号）
        //private int i;
        int i = 0;   //加不加private无所谓
        //private int i = 0;
        public void   F1()
        {
            //局部变量
            //定义在方法中，出了大括号就无法使用
            //局部变量在使用前必须进行初始化
            int j=1;
            Console.WriteLine(j*3);
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
            
        }
        public void F2()  
        {
            int j=1; //此时的j与F1中的j没有关系
            Console.WriteLine(j*3);
            
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
        }
        public void F3()  //如果局部变量与实例变量重名，局部变量优先
        {
            int  i= 1;  //此时的i与实例变量无关
            i++;
            Console.WriteLine(i);
        }
    }
}
