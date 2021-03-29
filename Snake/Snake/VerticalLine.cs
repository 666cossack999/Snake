using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        /// <summary>
        /// Заполняет список точками от yTop до yBot символами sym
        /// </summary>
        /// <param name="x">Широта линии</param>
        /// <param name="yTop">верхняя точка линии</param>
        /// <param name="yBot">нижняя точка линии</param>
        /// <param name="sym">Символ заполнения</param>
        public VerticalLine(int x, int yTop, int yBot, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBot; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
