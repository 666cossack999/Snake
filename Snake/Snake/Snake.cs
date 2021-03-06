using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
            if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.x == food.x && head.y == food.y)
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
