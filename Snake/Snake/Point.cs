using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }
        /// <summary>
        /// Точка
        /// </summary>
        /// <param name="_x">Координата широты</param>
        /// <param name="_y">Координата долготы</param>
        /// <param name="_sym"> Символ точки</param>
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        
        
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
                x += offset;
            else if (direction == Direction.Left)
                x -= offset;
            else if (direction == Direction.Up)
                y += offset;
            else if (direction == Direction.Down)
                y -= offset;
        }

        /// <summary>
        /// Отрисовка точки
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
