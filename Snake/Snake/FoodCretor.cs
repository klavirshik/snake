using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCretor
    {
        int xMapSize;
        int yMapSize;
        char sym;
        Random rnd = new Random();

        public FoodCretor(int xMapSize,int yMapSize, char sym)
        {
            this.xMapSize = xMapSize;
            this.yMapSize = yMapSize;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, xMapSize - 2);
            int y = rnd.Next(2, yMapSize - 2);
            return new Point(x, y, sym);
           
        }
    }
}
