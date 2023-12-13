using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTING_CALC
{
    public abstract class Operator : Token
    {
        public Operator(string symbol)
        {
            Symbol = symbol;
        }
        public string Symbol { get; set; }

    }
}
