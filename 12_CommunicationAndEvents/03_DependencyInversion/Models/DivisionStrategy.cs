using _03_DependencyInversion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_DependencyInversion.Models
{
    class DivisionStrategy : IStrategy
    {
        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
