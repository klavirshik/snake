using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            vertikalLine Vline = new vertikalLine(0, 24, 0, '|');
            Vline.Draw();
            vertikalLine Vline1 = new vertikalLine(0, 24, 78, '|');
            Vline1.Draw();
            horisontalLine line = new horisontalLine(0,78,0,'-');
            line.Draw();
            horisontalLine line1 = new horisontalLine(0, 78, 24, '-');
            line1.Draw();
            
            
            Point p = new Point(4,10,'*');
            snake Snak = new snake(p, 3, Direction.RIGHT);
            Snak.Draw();
           

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snak.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                Snak.Move();
            }

           
           
            //Console.ReadLine();
        }

       
    }
}
