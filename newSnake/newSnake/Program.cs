using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '*');
            p2.Draw();

            Point p3 = new Point(2, 4, '*');
            p3.Draw();

            Point p4 = new Point(3, 2, '*');
            p4.Draw();

            HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            hLine.Drow();
            
            

            Console.ReadLine();

        }


    }
}
