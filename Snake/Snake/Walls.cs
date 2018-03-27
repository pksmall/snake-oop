using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            // рисуем рамочку
            HorizontalLines xLine1 = new HorizontalLines(0, mapWidth - 2, 0, '+');
            HorizontalLines xLine2 = new HorizontalLines(0, mapWidth -2, mapHeight - 1, '+');
            VerticalLines yLine1 = new VerticalLines(0, mapHeight - 1, 0, '+');
            VerticalLines yLine2 = new VerticalLines(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(xLine1);
            wallList.Add(xLine2);
            wallList.Add(yLine1);
            wallList.Add(yLine2);
        }
        
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
