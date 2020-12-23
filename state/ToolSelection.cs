using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.state
{
    class ToolSelection : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection mouse down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection mouse up");
        }
    }
}
