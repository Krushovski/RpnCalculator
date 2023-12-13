using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING_CALC
{
    class Program
    {
        static void Main()
        {
            var calc = new RpnCalculator();
            calc.RegisterOperator(new Addition());
            calc.RegisterOperator(new Subtraction());
            calc.RegisterOperator(new Division());
            calc.RegisterOperator(new Multiplication());
            calc.RegisterOperator(new Factorial());
            string input;
            do
            {
                input = Console.ReadLine();
                if (input != "")
                    Console.WriteLine(calc.Evaluate(input));
            }
            while (input != "");
        }
    }
}
