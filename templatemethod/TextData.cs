using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.templatemethod
{
    public class TextData : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Read data from text");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Process Data in text");
        }

        
    }
}
