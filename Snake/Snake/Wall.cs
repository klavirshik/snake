using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figura> wallList;

        public Wall(int xMapSize, int yMapSize)
        {
            wallList = new List<Figura>();

            vertikalLine Vline = new vertikalLine(0, yMapSize-2, 0, '|');       
            vertikalLine Vline1 = new vertikalLine(0, yMapSize-2, xMapSize-2, '|');  
            horisontalLine line = new horisontalLine(0, xMapSize-2, 0, '-'); 
            horisontalLine line1 = new horisontalLine(0, xMapSize-2, yMapSize-2, '-');

            wallList.Add(Vline);
            wallList.Add(Vline1);
            wallList.Add(line);
            wallList.Add(line1);
        }

        internal bool IsHit(Figura figure)
        {
            foreach (var wall in wallList)
            {
                if (figure.IsHit(wall)) return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}
