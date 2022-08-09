using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanit
{
    public class Program 
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 5, 2, 1, 4, 5 };

            int min = myArray[0];

            for (int i = 1; i < myArray.Length; i++)    
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
