using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSnake
{
    class Figure
    {
        protected List<Point> pointList;

        public void Drow()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
            }
        }

    }
}
