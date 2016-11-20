using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameOver
    {
        string text;
        int start;
        public GameOver(string t)
        {
            text = t;
            start = (80 - text.Length) / 2;
        }

        public void Draw()
        {
            Console.SetCursorPosition(start, 12);
            Console.WriteLine(text);
           
        }
    }
}
