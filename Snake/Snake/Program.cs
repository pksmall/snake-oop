using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLines xLine = new HorizontalLines(5, 10, 8, '+');
            xLine.Draw();

            VerticalLines yLine = new VerticalLines(5, 10, 8, '*');
            yLine.Draw();

            Console.ReadLine();
        }

    }
}
