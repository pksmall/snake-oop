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

            VerticalLines v1 = new VerticalLines(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLines h1 = new HorizontalLines(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
