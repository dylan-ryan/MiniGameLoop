using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MiniGame");
            Console.WriteLine();

            //for loops
            //count 1 to 10
            //for(int i=1; i <=10; i++) //i++ = ( i = i + 1)
            //{
            //     Console.WriteLine(i);
            //}
            //Console.WriteLine(i); // doesnt exist outside of for()

            //3 parts:
            //1: declaration/initialization at once -- start at 1 ---outside loop
            //2: test ---before loop
            //---inside of loop 
            //3: increment --- bottom of loop

            //while loops
            // 1. init -- in unity = StartUp() -- run once
            char avatar = '@';
            bool gameOver = false;
            int x = 30; //player position
            int y = 10; //player position

                //game loop
            while(gameOver != true) // !=   =   is not true
            {
                //2. update -- in unity == Update
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if(input.Key == ConsoleKey.W)
                {
                    y = y - 1;
                    if (y < 0) y = 0;
                }
                if(input.Key == ConsoleKey.S)
                {
                    y = y + 1;
                    if (y < 0) y = 0;
                    if (y > 20) y = 20;
                }
                if (input.Key == ConsoleKey.D)
                {
                    x = x + 1;
                    if (x < 0) x = 0;
                    if (x > 60) x = 60;
                }
                if(input.Key == ConsoleKey.A)
                {
                    x = x - 1;
                    if (x < 0) x = 0;
                }
                //3. draw -- in unity auto happens
                Console.SetCursorPosition(x, y); // player position
                Console.WriteLine(avatar); //player avatar

            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
