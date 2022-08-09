using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress
{
    public class ConsoleProgress : ProgressMeter
    {
        public ConsoleProgress(int max) : base(max) { }
        public override void Draw()
        {
            int maxChars = 30;
            double ratio = (double)Position / max;
            int nStars = (int)(maxChars * ratio);
            int nEquals = maxChars - nStars;
            for (int i = 0; i < nStars; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < nEquals; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}
