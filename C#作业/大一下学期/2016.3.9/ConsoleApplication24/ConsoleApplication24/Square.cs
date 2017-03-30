using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Square : Shape
    {
        public double X
        {
            get;
            set;
        }

        public double GetArea()
        {
            return Math.Pow(X, 2);
        }

        public double GetPerimeter()
        {
            return 4 * X;
        }
    }
}
