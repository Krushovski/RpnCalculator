using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING_CALC
{
    public class Addition : Operator
    {
        public Addition()
            : base("+")
        {
        }

        public override void ProcessWith(Stack<Operand> stack)
        {
            var op2 = stack.Pop();
            var op1 = stack.Pop();

            stack.Push(new Operand(op1.Value + op2.Value));
        }
    }
    public class Subtraction : Operator
    {
        public Subtraction()
            : base("-")
        {
        }

        public override void ProcessWith(Stack<Operand> stack)
        {
            var op2 = stack.Pop();
            var op1 = stack.Pop();

            stack.Push(new Operand(op1.Value - op2.Value));
        }
    }
    public class Multiplication : Operator
    {
        public Multiplication()
            : base("*")
        {
        }

        public override void ProcessWith(Stack<Operand> stack)
        {
            var op2 = stack.Pop();
            var op1 = stack.Pop();

            stack.Push(new Operand(op1.Value * op2.Value));
        }
    }
    public class Division : Operator
    {
        public Division()
            : base("/")
        {
        }

        public override void ProcessWith(Stack<Operand> stack)
        {
            var op2 = stack.Pop();
            var op1 = stack.Pop();

            stack.Push(new Operand(op1.Value / op2.Value));
        }
    }
    public class Factorial : Operator
    {
        public Factorial()
            : base("!")
        {
        }

        public override void ProcessWith(Stack<Operand> stack)
        {
            var op = stack.Pop();
            long asLong = (long)op.Value;
            if (asLong != op.Value || asLong < 0)
                throw new InvalidOperationException("Non integer and negative factorials are not supported.");
            ulong result = 1;
            for (ulong i = 1; i <= (ulong)asLong; ++i)
                result *= i; 

            stack.Push(new Operand(result));
        }
    }
}
