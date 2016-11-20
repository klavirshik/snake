﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class snake : Figura
    {
        Direction dir;

        public snake(Point tail, int lenght,Direction direction)
        {
            dir = direction;
            pList = new List<Point>();
            for (int i = 0; i< lenght; i++)
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

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for(int i = 0; i < pList.Count-2; i++)
            {
                if (head.isHit(pList[i]))
                    return true;
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, dir);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && dir != Direction.RIGHT) dir = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow && dir != Direction.LEFT) dir = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow && dir != Direction.DOWN) dir = Direction.UP;
            else if (key == ConsoleKey.DownArrow && dir != Direction.UP) dir = Direction.DOWN;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                Point f = new Point(food);
                f.sym = head.sym;
                pList.Add(f);
                f.Draw();
                return true;
            }
            else return false;
        }
    }
}
