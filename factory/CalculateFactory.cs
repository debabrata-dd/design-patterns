using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculate(string value)
        {
            ICalculate calculate = null;
            switch (value.ToLower())
            {
                case "add":
                    calculate = new Add();
                    break;
                case "subtract":
                    calculate = new Subtract();
                    break;
                case "devide":
                    calculate = new Devide();
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }

            return calculate;
        }
    }
}
