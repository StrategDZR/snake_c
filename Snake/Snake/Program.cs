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
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
               
            }
        }
    }
}
