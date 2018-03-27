﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines
    {
        List<Point> pList;

        public VerticalLines(int yTop, int xBottom, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yTop; y <= xBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
