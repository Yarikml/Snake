﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSnake
{
    class VerticalLine : Figure
    {
       

        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            pointList = new List<Point>();

            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pointList.Add(p);
            }
        }

        

    }
}
