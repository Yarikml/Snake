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

            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            topLine.Drow();
            bottomLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Console.ReadLine();

        }


    }
}
