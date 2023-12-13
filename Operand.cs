using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING_CALC
{
    public class Operand : Token
    {
        public decimal Value { get; set; }

        public Operand(decimal val)
        {
            Value = val;
        }
        public override void ProcessWith(Stack<Operand> stack)
        {
            stack.Push(this); 
        }
    }
}
