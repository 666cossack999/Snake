using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(1,8,5,'*');
            line.Drow();

            VerticalLine line1 = new VerticalLine(3, 2, 12, '+');
            line1.Drow();

            Console.ReadLine();

        }


    }
}
