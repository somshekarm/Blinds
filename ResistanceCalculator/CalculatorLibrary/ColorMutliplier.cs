using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class ColorMutliplier
    {
        public ColorMutliplier(char symbol, double value)
        {
            Symbol = symbol;
            Value = value;
        }
       public char Symbol { get; private set; }
        public double Value { get; private set; }
    }
}
