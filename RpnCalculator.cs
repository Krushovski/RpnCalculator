using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING_CALC
{
    class RpnCalculator
    {
        private List<Operator> operators = new List<Operator>();

        public decimal Evaluate(string expression)
        {
            var tokens = expression.Split(' ');

            var stack = new Stack<Operand>();

            foreach  (var str in tokens)
            {
                var token = CreateToken(str);
                token.ProcessWith(stack); 
            }
            return stack.Pop().Value;
        }
        public void RegisterOperator(Operator op)
        {
            operators.Add(op);
        }
        private Token CreateToken(string str)
        {
            if (decimal.TryParse(str, out decimal val))
                return new Operand(val);

            foreach (var op in operators)
                if (op.Symbol == str)
                    return op;

            throw new Exception($"Unsupported operator : '{str}' ");
            
        }
    }
}
