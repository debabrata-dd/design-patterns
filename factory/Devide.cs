using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.factory
{
    public class Devide : ICalculate
    {
        public void Calculate(double num1, double num2)
        {
            Console.WriteLine("a/b = {0}", num1 / num2);
        }
    }
}
