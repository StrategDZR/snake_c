using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //рамка поля
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, 78, 23, '*');
            VerticalLine leftLine = new VerticalLine(0, 0, 23, '*');
            VerticalLine rightLine = new VerticalLine(78, 0, 23, '*');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //точка на поле
            Point p = new Point(23, 12, '*');

            //создание змейки
            Snake snake = new Snake(p, 8, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
         


            Console.ReadLine();
        }
    }
}
