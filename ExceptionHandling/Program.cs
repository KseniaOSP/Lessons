using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    interface INamed
    {
        string Name { get; }
    }

    interface IValue
    {
        int GetValue();
    }

    interface IOperation
    {
       IValue Execute(IValue a, IValue b);
    }


    public class Operand : IValue, INamed
    {
        readonly int value;
        public Operand(int value) { this.value = value; }

        public string Name => Convert.ToString(value);
        
        public int GetValue()
        {
          return value;
        }
    }

    class Sum : IOperation, INamed
    {
        public string Name => "sum";

        public IValue Execute(IValue a, IValue b)
        {
            return new Operand(a.GetValue()+b.GetValue());
        }
    }
    class Sub : IOperation, INamed
    {
        public string Name => "sub";

        public IValue Execute(IValue a, IValue b)
        {
            return new Operand(a.GetValue() - b.GetValue());
        }
    }

    class Mult : IOperation, INamed
    {
        public string Name => "mult";

        public IValue Execute(IValue a, IValue b)
        {
            return new Operand(a.GetValue() * b.GetValue());
        }
    }
    class Div : IOperation, INamed
    {
        public string Name => "div";

        public IValue Execute(IValue a, IValue b)
        {
            return new Operand(a.GetValue() / b.GetValue());
        }
    }
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

                IValue xval = new Operand(x);
                IValue yval = new Operand(y);

                IOperation op;
                switch (operation)
                {
                    case '+':
                        op = new Sum();
                        break;
                    case '-':
                        op = new Sub();
                        break;
                    case '*':
                        op = new Mult();
                        break;
                    case '/':
                        op = new Div();
                        break;
                    default:
                        logger.Error("Unknown operation");
                        return;
                }

                int result = op.Execute(xval, yval).GetValue();

                Console.WriteLine(result);
                
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
