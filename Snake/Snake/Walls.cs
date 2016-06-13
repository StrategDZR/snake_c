using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallslist;

        public Walls(int mapWidth, int mapHeight)
        {
            wallslist = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '*');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 2, '*');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 2, '*');
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 2, '*');

            wallslist.Add(upLine);
            wallslist.Add(downLine);
            wallslist.Add(rightLine);
            wallslist.Add(leftLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallslist)
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
            foreach(var wall in wallslist)
            {
                wall.Draw();
            }
        }
    }
}
