using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        //玩家当前游戏状态：赢， 输， 继续
        //              i   1   2    3
        //int i = 0;

        Random r = new Random();    // 实例变量，在类中所有的方法都可以访问         
        public int Roll()
        {
            int x = r.Next(1, 7);
            int y = r.Next(1, 7);
            Console.WriteLine(x + y);
            return x + y;
        }
        public void Game()
        {
            int i = 0;
            int m = Roll();
            int s = 1;
            if (m == 7 || m == 11)
                i = 1;
            else if (m == 2 || m == 3 || m == 12)
                i = 2;
            else
                i = 3;
            while (i == 3)
            {
                int n = Roll();
                s++; 
                if (n == 7)
                    i = 2;
                else if (n == m)
                    i = 1;
            } if (i == 1)
                Console.WriteLine("Win:" + s);
            else
                Console.WriteLine("Lose:" + s);
        }






        public int Roll1()    //玩1000局
        {
            int x = r.Next(1, 7);
            int y = r.Next(1, 7);
            Console.WriteLine(x + y);
            return x + y;
        }
        public int  Game1()
        {
            int i = 0;
            int m = Roll();
            int s = 1;
            if (m == 7 || m == 11)
                i = 1;
            else if (m == 2 || m == 3 || m == 12)
                i = 2;
            else
                i = 3;
            while (i == 3)
            {
                int n = Roll1();
                s++;
                if (n == 7)
                    i = 2;
                else if (n == m)
                    i = 1;
            } if (i == 1)
                Console.WriteLine("Win:" + s);
            else
                Console.WriteLine("Lose:" + s);
            return i;
        }
        public void F()
        {
            int win = 0;
            for (int c = 1; c <= 1000; c++)
            {
                int y = Game1();

                if (y == 1)
                    win++;
                int lose = 1000 - win;
                Console.WriteLine("win={0},lose={1}",win ,lose );
 
            }
        }



    }
}
