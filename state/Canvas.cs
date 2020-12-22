using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.state
{
    public class Canvas
    {
        public ITool CurrentTool { get; set; }
        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }

        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }
    }
}
