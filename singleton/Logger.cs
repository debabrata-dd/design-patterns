using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.singleton
{
    public class Logger
    {
        private static int counter;
        private static Logger logger;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                counter++;
                if(logger == null)
                {
                    logger = new Logger();
                }
                return logger;
            }
        }

        public static int Counter
        {
            get
            {
                return counter;
            }
        }
    }
}
