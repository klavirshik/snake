using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food:Point
    {
        public Food(int _x, int _y, char _sym)
            :base(_x, _y, _sym)
        {
                 }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
