using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figura
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figura fig)
        {
           
            foreach (var p in pList)
            {
                if (fig.IsHit(p)) return true;
            }
            return false;
      
       }
        internal bool IsHit(Point point)
        {

            foreach (var p in pList)
            {
                if (p.isHit(point)) return true;
            }
            return false;

        }
    }
}
