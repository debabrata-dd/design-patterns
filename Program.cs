using design_patterns.memento;
using design_patterns.singleton;
using design_patterns.state;
using System;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoSingleton();

            //DemoStatePattern();
            //DemoMementoPattern();

        }

        private static void DemoSingleton()
        {
            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine(Logger.Counter);
        }

        private static void DemoMementoPattern()
        {
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
        }

        private static void DemoStatePattern()
        {
            Canvas canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
