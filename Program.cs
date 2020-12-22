using design_patterns.memento;
using design_patterns.state;
using System;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {


            //State Pattern
            /*
            Canvas canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
            */

            //Memento Pattern
            /*
            Editor editor = new Editor();
            History history = new History();

            editor.Content = "a";
            history.push(editor.CreateState());

            editor.Content = "b";
            history.push(editor.CreateState());

            editor.Content = "c";
            editor.restore(history.pop());
            editor.restore(history.pop());

            Console.WriteLine(editor.Content);
            */
        }
    }
}
