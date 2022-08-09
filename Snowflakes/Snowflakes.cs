using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snowflakes
{
      
    public class Snowflakes
    {
        readonly int width;
        readonly int height;

        readonly Random random = new Random();

        readonly bool[,] screen;

        public Snowflakes(int width, int height)
        {
            this.width = width;  
            this.height = height;
            screen = new bool[height, width];
        }

        public void MakeBlizzard()
        {
            while (true)
            {
                OutputSnowflakesToScreen();
                Thread.Sleep(500);
                Console.Clear();
                UpdateSnowflakes();
            }   
        }

        // 1-й метод - отображение снежинок на экране
        void OutputSnowflakesToScreen()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (screen[i, j] == true)
                        Console.Write("*");
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        // 2-й метод - двигает снежинки
        void UpdateSnowflakes()
        {
            for (int i = height - 1; i > 0; i--)
            {
                for (int j = 0; j < width; j++)
                {
                    screen[i, j] = screen[i - 1, j];
                }
            }
            for (int j = 0; j < width; j++)
            {
                screen[0, j] = random.NextDouble() < 0.1;
            }
        }
    }
    public class DrawSnow 
    {
        DrawSnow drawsnow = new DrawSnow();
    }
}
