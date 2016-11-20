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
            Wall wall;
            Point p;
            snake Snak;
            FoodCretor FoodCr;
            Food food;



            while (true)
            {

                wall = new Wall(80, 25);
                wall.Draw();
                p = new Point(4, 10, '*');
                Snak = new snake(p, 3, Direction.RIGHT);
                Snak.Draw();
                FoodCr = new FoodCretor(80, 25, 'O');
                food = FoodCr.CreateFood();
                food.Draw();




                while (true)
                {
                    if (wall.IsHit(Snak) || Snak.IsHitTail())
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

                GameOver GO = new GameOver("GAME OVER");
                GO.Draw();
                
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape)
                        {
                            Environment.Exit(0);
                        }
                        else break;
                    }
                    Thread.Sleep(100);
                }
                Console.Clear();
            }
        }
       
    }
}
