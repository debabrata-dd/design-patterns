using design_patterns.factory;
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

            DemoFactory();

            //DemoSingleton();
            //DemoStatePattern();
            //DemoMementoPattern();

        }

        private static void DemoFactory()
        {
            CalculateFactory factory = new CalculateFactory();
            Console.WriteLine("Enter 2 numbers:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operation (add/subtract/devide):");
            ICalculate obj = factory.GetCalculate(Console.ReadLine());
            obj.Calculate(a, b);
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
            canvas.CurrentTool = new ToolSelection();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new ToolBrush();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
