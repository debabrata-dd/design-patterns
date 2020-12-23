using design_patterns.factory;
using design_patterns.memento;
using design_patterns.singleton;
using design_patterns.state;
using design_patterns.templatemethod;
using System;
using System.Threading.Tasks;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoTemplateMethod();
            //DemoFactory();
            DemoSingleton();
            //DemoStatePattern();
            //DemoMementoPattern();

        }

        private static void DemoTemplateMethod()
        {
            DataProcessor excel = new ExcelData();
            excel.ReadProcessAndSave();

            DataProcessor text = new TextData();
            text.ReadProcessAndSave();
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
            Parallel.Invoke(()=>StudentLog(), ()=> EmployeeLog());

            Console.WriteLine(Logger.Counter);
            //StudentLog();
            //EmployeeLog();

            //Console.WriteLine(fromStudent.GetHashCode());
            //Console.WriteLine(fromEmployee.GetHashCode());
        }

        private static void EmployeeLog()
        {
            Logger fromEmployee = Logger.GetInstance;
            fromEmployee.Log("Object2 created");
        }

        private static void StudentLog()
        {
            Logger fromStudent = Logger.GetInstance;
            fromStudent.Log("Object1 created");
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
