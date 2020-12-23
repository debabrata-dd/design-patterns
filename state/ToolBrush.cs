using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.state
{
    class ToolBrush : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush mouse down");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush mouse up");
        }
    }
}
