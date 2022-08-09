using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snowflakes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину и высоту снежного поля");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());   
            Snowflakes snowflakes = new Snowflakes(width, height);
            snowflakes.MakeBlizzard();
        }
    }
}

