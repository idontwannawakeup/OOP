using _03_DependencyInversion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_DependencyInversion.Models
{
    class PrimitiveCalculator
    {
        private IStrategy strategy;

        public void ChangeStrategy(char @operator)
        {
            strategy = @operator switch
            {
                '+' => new AdditionStrategy(),
                '-' => new SubstractionStrategy(),
                '*' => new MultiplicationStrategy(),
                '/' => new DivisionStrategy(),
                _ => throw new ArgumentException("Invalid operator!")
            };
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
            => strategy.PerformCalculation(firstOperand, secondOperand);

        public PrimitiveCalculator()
            : this(new AdditionStrategy())
        { }

        public PrimitiveCalculator(IStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}
