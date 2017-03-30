using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.Radius = 10;

            Circle c2 = new Circle();
            c2.Radius = 20;

            Square s1 = new Square();
            s1.X = 30;

            Square s2 = new Square();
            s2.X = 40;

            Shape[] array_s = new Shape[4];
            array_s[0] = c1;
            array_s[1] = c2;
            array_s[2] = s1;
            array_s[3] = s2;

            foreach (var v in array_s)
            {
                if (v is Square)
                {
                    Square temp = (Square)v;
                    Console.WriteLine("Square Perimeter:" + temp.GetPerimeter());
                }
                else
                    Console.WriteLine("Circle Area:" + v.GetArea());
            }
        }
    }
}
