using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Program
    {
           
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            
            Console.WriteLine("Введите выражение из двух операндов и одной операции (*/-+)");
            string input = Console.ReadLine();
            try
            {
                int nondigitIndex = -1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                    {
                        nondigitIndex = i;
                        break;
                    }
                }
                int x = Convert.ToInt32(input.Substring(0, nondigitIndex));
                char operation = input[nondigitIndex];
                int y = Convert.ToInt32(input.Substring(nondigitIndex + 1, input.Length - nondigitIndex - 1));

                int result;
                {
                    switch (operation)
                    {
                        case '+':
                            result = x + y;
                            break;
                        case '-':
                            result = x - y;
                            break;
                        case '*':
                            result = x * y;
                            break;
                        case '/':
                            result = x / y;
                            break;
                        default:
                            logger.Error("Unknown operation");
                            return;
                    }
                    Console.WriteLine(result);
                }
            }
            catch (DivideByZeroException)
            {
                logger.Error("The denominator is zero");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            Console.ReadLine();
           
        }
    }
}
