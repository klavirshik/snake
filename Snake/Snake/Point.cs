using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public  Point(int _x, int _y, char _sym)
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

        public void Move(int offset, Direction dir)
        {
            if(dir == Direction.UP)
            {
                y = y - offset;
            }
            if(dir == Direction.DOWN)
            {
                y = y + offset;
            }
            if(dir == Direction.RIGHT)
            {
                x = x + offset;
            }
            if(dir == Direction.LEFT)
            {
                x = x - offset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool isHit(Point food)
        {
            return (x == food.x) && (y == food.y);   
        }
    }
}
