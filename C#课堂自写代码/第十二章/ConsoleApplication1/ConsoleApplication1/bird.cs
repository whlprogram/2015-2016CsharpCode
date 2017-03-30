using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class bird: animal 
    {
        public int I { get; set; }

        public override  void Move()
        {
            F(); //可以引用，但不可以写public override  void F()
            color = "red";
            Console.WriteLine("red");

            I += 10;
            Console.WriteLine("bird Move"+I);
        }

    }
}
