using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress
{
    public sealed class Percent : ConsoleProgress
    {
        public Percent(int max) : base(max) { }

        public override void Draw()
        {
            base.Draw();
            double ratio = (double)Position / max;
            Console.Write($"{ratio * 100}% / {100 - ratio * 100}%");
        }

    }

   
}
