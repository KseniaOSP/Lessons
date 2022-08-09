using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.WriteLine("Введите день недели (1-7)");
            int day = int.Parse(Console.ReadLine());

            if (day <= 5 && day > 0)
            {
                
                    PrintColored("Расписание для будничного дня", WeekdayColor());
            }
            else if (day ==6 || day == 7)
            {
                   PrintColored("Расписание для выходных дней", ConsoleColor.Red);
            }
            else
            {
                Console.WriteLine("Такого дня недели нет");
            }
            }           
        }
        private static void PrintColored(string text, ConsoleColor textcolor)
        {
            Console.ForegroundColor = textcolor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        private static ConsoleColor WeekdayColor()
        { 
        return ConsoleColor.Yellow;    
        }
    }
}
