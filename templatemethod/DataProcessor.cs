using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.templatemethod
{
    public abstract class DataProcessor
    {
        public void ReadProcessAndSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        protected abstract void ReadData();
        protected abstract void ProcessData();

        protected void SaveData()
        {
            Console.WriteLine("Save data into DB");
        }
    }
}
