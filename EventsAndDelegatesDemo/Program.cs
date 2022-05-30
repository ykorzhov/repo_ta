using System;
using System.Linq;

namespace EventsAndDelegatesDemo
{
    class Program
    {
        delegate int Calc(int a, int b);

        static event Calc DoCalc;

        delegate void DisplayText(string text);

        public static int Add(int a, int b)
        {
            Console.WriteLine("Add method ->");
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            Console.WriteLine("Minus method ->");
            return a - b;
        }

        public static void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {
            Calc a = Add;
            int res = a(2, 3);

            Console.WriteLine($"result = {res}");

            a += Minus;
            res = a(2, 2);

            Console.WriteLine($"result = {res}");

            var delegates = a.GetInvocationList();

            var r1 = delegates[1].DynamicInvoke(1, 1);
            Console.WriteLine($"r1 = {r1}");

            var r2 = delegates[0].DynamicInvoke(1, 1);
            Console.WriteLine($"r2 = {r2}");

            DoAction(Add, 1, 2);
            DoAction(Minus, 1, 2);

            DisplayText output = WriteText;
            output.Invoke("DisplayText delegate ==========");

            // Event:
            DoCalc += OnCalc;

            DoCalc(2, 2);

            Console.ReadKey();

            DoCalc -= OnCalc;

            //RaiseEvent event1 = new RaiseEvent();
            //event1.DoCalc += Event1_DoAdd;
            //event1.Raise(2, 2);

            //RaiseEvent event2 = new RaiseEvent();
            //event2.DoCalc += Event2_DoMinus;
            //event2.Raise(2, 2);

            //RaiseEvent event3 = new RaiseEvent();
            //event3.Raise(2, 2);

            //event1.DoCalc -= Event1_DoAdd;
            //event2.DoCalc -= Event2_DoMinus;

            // Action:
            Action<string> displayText = WriteText;
            displayText.Invoke("Action ===========");

            // Func:
            Func<int, int, int> func = Add;
            var result = func.Invoke(1, 3);
            displayText($"result = {result}");

            // Anonymous method:
            Func<int, int> square = delegate (int x)
            {
                return x * x;
            };

            displayText($"square = {square(3)}");

            // lambda
            Func<int, int, int> add = (number1, number2) => number1 + number2;
            DoAction(add, 1, 2);

            DoAction((number1, number2) => number1 + number2, 1, 2);

            var first = delegates.Where(i => i.Method.Name == "name1");
            var second = delegates.Where(i => i.Method.Name.Contains("name2"));

            Console.ReadKey();
        }

        private static int Event2_DoMinus(int a, int b)
        {
            Calc minus = Minus;
            int res = minus(2, 2);

            Console.WriteLine($"{minus} = {res}");

            return res;
        }

        private static int Event1_DoAdd(int a, int b)
        {
            Calc add = Add;
            int res = add(2, 2);

            Console.WriteLine($"{add} = {res}");

            return res;
        }

        //private static void DoAction(Calc calculate, int a, int b)
        //{
        //    var result = calculate.DynamicInvoke(a, b);
        //    Console.WriteLine($"result = {result}");
        //}

        private static void DoAction(Func<int, int, int> calculate, int a, int b)
        {
            var result = calculate.DynamicInvoke(a, b);
            Console.WriteLine($"result = {result}");
        }

        private static int OnCalc(int a, int b)
        {
            Calc add = Add;
            int res = add(2, 2);

            Console.WriteLine($"{add} = {res}");

            return res;
        }
    }
}
