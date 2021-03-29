using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        /// <summary>
        /// Заполняет список точками от xLeft до xRight
        /// </summary>
        /// <param name="xLeft">Крайняя левая точка</param>
        /// <param name="xRight">Крайняя правая точка</param>
        /// <param name="y">Долгота линии</param>
        /// <param name="sym">Символ заполнения</param>
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <=xRight ; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
