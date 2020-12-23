using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.singleton
{
    public sealed class Logger
    {
        private static int counter = 0;
        //private static readonly object obj = new object();
        private Logger() { counter++; }

        private static readonly Lazy<Logger> instance = new Lazy<Logger>(()=> new Logger());
        public static Logger GetInstance
        {
            get
            {
                //double-checked locking
                //if (instance == null)
                //{
                //    lock (obj)
                //    {
                //        if (instance == null)
                //        {
                //            instance = new Logger();
                //        }
                //    }
                //}


                return instance.Value;
            }
        }

        public void Log(string value)
        {
            Console.WriteLine(value);
        }

        public static int Counter
        {
            get { return counter; }
        }
        
    }
}
