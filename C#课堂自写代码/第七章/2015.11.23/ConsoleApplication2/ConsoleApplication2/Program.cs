using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static Random randomNumbers = new Random();
        //CONTINUE,WON,LOST相当于三个常量，如果不赋值的话，有默认值，都是静态的
        //Status可以作为一个新的类型来使用，可以定义Status类的对象
        private enum Status { CONTINUE , WON , LOST}
        private enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 7,
            YO_LEVEN = 11,
            BOX_CARS =12
        }
        static void Main(string[] args)
        {
            
            Status gameStatus = Status.CONTINUE;
            int myPoint = 0;
            
            int sumOfDice = RollDice();
            switch ((DiceNames)sumOfDice)
            {
                case  DiceNames.SEVEN :
                case  DiceNames.YO_LEVEN:
                    gameStatus = Status.WON;
                    break;
                case DiceNames.SNAKE_EYES :
                case DiceNames.TREY:
                case DiceNames.BOX_CARS :
                    gameStatus = Status.LOST;
                    break;
                default :
                    gameStatus =Status.CONTINUE;
                    myPoint = sumOfDice;
                    Console.WriteLine("Point is {0}",myPoint );
                    break;
            }
            while (gameStatus == Status.CONTINUE)
            {
                sumOfDice = RollDice();
                if (sumOfDice == myPoint)
                    gameStatus = Status.WON;
                else
                    if (sumOfDice == (int)DiceNames.SEVEN)
                        gameStatus = Status.LOST;          
            }
            if (gameStatus == Status.WON)
                Console.WriteLine("Player wins");
            else
                Console.WriteLine("Player loses");
        }
        public   static int RollDice()
        {
            int die1 = randomNumbers .Next (1,7);
            int die2 = randomNumbers .Next (1,7);
            int sum = die1 + die2 ;
            Console .WriteLine ("Player rolled {0}+{1}={2}",die1 ,die2 ,sum );
            return sum ;
        }
    }
}