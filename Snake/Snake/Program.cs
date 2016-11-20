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

            Wall wall = new Wall(80, 25);
            wall.Draw();
            
            
            
            Point p = new Point(4,10,'*');
            snake Snak = new snake(p, 3, Direction.RIGHT);
            Snak.Draw();
            
            FoodCretor FoodCr = new FoodCretor(80, 25, 'O');
            Food food = FoodCr.CreateFood();
            
            food.Draw();
            



            while(true)
            {
                if(wall.IsHit(Snak)||Snak.IsHitTail())
                {
                    break;
                }

                if (Snak.Eat(food))
                {
                    food = FoodCr.CreateFood();
                    food.Draw();
                }
                else
                {
                    Snak.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snak.HandleKey(key.Key);
                }
                Thread.Sleep(100);
              
            }

           
           
            //Console.ReadLine();
        }

       
    }
}
