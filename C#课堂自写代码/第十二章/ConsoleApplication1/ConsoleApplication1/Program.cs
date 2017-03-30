using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bird  c1 = new bird();
            animal a1 = c1;

            a1.Move();

            //animal [] array_B = new animal [100];
            //array_B[0] = new bird();
            //array_B[1] = new fish();
            //array_B[2] = new bird();
            //array_B[3] = new forg();

            //foreach (var t in array_B)
            //{
            //    if (t != null)
            //        t.Move();
            //}
            //foreach (var t in array_B)
            //{
            //    if (t != null)
            //        t.Move();
            //}

            animal[] array_B = new animal[4];
            array_B[0] = new bird();
            array_B[1] = new fish();
            array_B[2] = new bird();
            array_B[3] = new forg();

            foreach (animal t in array_B)
            {
                if (t is  bird)
                    t.Move();
                if (t is forg)
                    t.Move();
                if (t is fish)
                { 
                    fish f = (fish )t;
                    f.sec_Move();
                }

            }

        }
    }
}
