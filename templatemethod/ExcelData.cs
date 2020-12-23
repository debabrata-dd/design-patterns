using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.templatemethod
{
    public class ExcelData : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Read data from excel");
        }
        protected override void ProcessData()
        {
            Console.WriteLine("Process Data in excel");
        }

        
    }
}
