using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class forg : animal 
    {
        public int I { get; set; }

        public override void Move()
        {
            I += 3;
            Console.WriteLine("forg Move" + I);
        }
    }
}
