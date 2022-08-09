using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProgressMeter meter = new Percent(100);
            meter.Position = 42;
            meter.Draw();
            Console.ReadLine();
        }
    }
}
