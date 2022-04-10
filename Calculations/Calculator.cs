using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculator : ICalculator
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        public decimal Multiply(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        public decimal Subtract(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }
    }
}
