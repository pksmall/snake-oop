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
            // установка размеров экрана консоли 
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            // рисуем рамочку
            HorizontalLines xLine1 = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines xLine2 = new HorizontalLines(0, 78, 24, '+');
            xLine1.Draw();
            xLine2.Draw();

            VerticalLines yLine1 = new VerticalLines(0, 24, 0, '+');
            VerticalLines yLine2 = new VerticalLines(0, 24, 78, '+');
            yLine1.Draw();
            yLine2.Draw();

            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }
    }
}
