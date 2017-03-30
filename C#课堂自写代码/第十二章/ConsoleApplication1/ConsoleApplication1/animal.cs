using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class animal
    {
       // public int MyProperty { get; set; }   // prop +两次Tab
        int i;
        public string color = "";

        public int I { get; set; }

        public void F()
        { 
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal Move");
        }

    }
}
