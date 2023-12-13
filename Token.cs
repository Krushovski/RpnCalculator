using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING_CALC
{
    public abstract class Token
    {
        public abstract void ProcessWith(Stack<Operand> stack);
    }
}
