using System;
using System.Collections.Generic;
using System.Text;

namespace _03_DependencyInversion.Interfaces
{
    interface IStrategy
    {
        int PerformCalculation(int firstOperand, int secondOperand);
    }
}
