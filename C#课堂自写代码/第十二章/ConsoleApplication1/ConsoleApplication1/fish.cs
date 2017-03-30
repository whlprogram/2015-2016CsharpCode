using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class fish: animal 
    {
        public int I { get; set; }

        public override void Move()
        {
            I += 5;
            Console.WriteLine("fish Move" + I);
        }
        public void sec_Move()
        {
            I += 100;
            Console.WriteLine("sec_Move" + I);
        }
    }
}
