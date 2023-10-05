using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab02 {
    internal class Program {
        static void Main(string[] args) {
            Task2();
            Task3();
            Task4();
        }

        static void Task2() {
            DoubleStack stack1 = new DoubleStack(12);
            DoubleStack stack2 = new DoubleStack();
            DoubleStack stack3 = new DoubleStack(stack1);
            
            Console.WriteLine(stack1.GetInfo());
            Console.WriteLine(stack2.GetInfo());
            Console.WriteLine(stack3.GetInfo());
            Console.WriteLine(DoubleStack.GetClassInfo());

            Console.WriteLine($"stack1.Capacity: {stack1.Capacity}");
            Console.WriteLine($"stack2.Capacity: {stack2.Capacity}");

            Console.WriteLine($"stack1.Equals(stack2): {stack1.Equals(stack2)}");
            Console.WriteLine($"stack1 == stack2: {stack1 == stack2}");

            Console.WriteLine($"stack1: {stack1}");
            stack1.Push(12.4);
            Console.WriteLine($"stack1: {stack1}");
            stack1.Push(1.344);
            Console.WriteLine($"stack1: {stack1}");
            Console.WriteLine($"stack1[1]: {stack1[1]}");
            Console.WriteLine($"stack1.Count: {stack1.Count}");
            Console.WriteLine($"stack1.Pop(): {stack1.Pop()}");
            Console.WriteLine($"stack1: {stack1}");
            Console.WriteLine($"stack1.Pop(): {stack1.Pop()}");
            Console.WriteLine($"stack1: {stack1}");
            Console.WriteLine($"stack1.IsEmpty: {stack1.IsEmpty}");
            try {
                Console.WriteLine($"stack1.Pop(): {stack1.Pop()}");
            }
            catch (InvalidOperationException ex) {
                Console.WriteLine(ex);
            }

            stack1.Push(12.3);
            stack2.Push(12.3);
            stack1.Push(11.4);
            Console.WriteLine($"stack1 == stack2: {stack1 == stack2}");
            stack1.Pop();
            Console.WriteLine($"stack1 == stack2: {stack1 == stack2}");

            Console.WriteLine($"stack1: {stack1}");
            stack1.Clear();
            Console.WriteLine($"stack1: {stack1}");

            stack2 = null;

            DoubleStack stack4 = new DoubleStack(10);
            stack4.Push(11.5);
            Console.WriteLine($"stack4: {stack4}");
            double newValue = 45.7;
            double oldValue;
            stack4.SwapLast(ref newValue, out oldValue);
            Console.WriteLine($"oldValue: {oldValue}");
            Console.WriteLine($"stack4: {stack4}");

            Console.WriteLine(DoubleStack.GetClassInfo());
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine(DoubleStack.GetClassInfo());
        }

        static void Task3() {
            DoubleStack[] stacks = new DoubleStack[] {
                new DoubleStack(new List<double>() { 12.5, 34.5, 18.2, -7.8, 42.1, -3.14, 9.0, 22.7, 15.3, 6.6 }),
                new DoubleStack(new List<double>() { 3.33, 17.8, 29.1, 8.7, 14.2, 5.0, 19.6, 37.4, 2.2, 11.1 }),
                new DoubleStack(new List<double>() { 21.9, 6.4, 13.7, 31.8, -10.5, 4.2, 27.0, 16.6, 8.9, 35.2 }),
                new DoubleStack(new List<double>() { 9.5, 38.7, 22.3, 2.8, 14.6, 30.0, 11.9, 5.5, 17.3, 40.1 }),
                new DoubleStack(new List<double>() { 20.2, 7.0, 33.6, 12.3, 6.1, 25.9, 3.7, 19.4, 8.3, 36.8 }),
                new DoubleStack(new List<double>() { 15.8, 4.9, -10.2, 28.4, -32.0, 7.2, 23.5, 13.1, -5.8, 9.3 }),
                new DoubleStack(new List<double>() { 11.7, 26.3, 8.0, 37.9, 2.5, 16.8, 34.9, 6.7, 12.0, 21.4 }),
                new DoubleStack(new List<double>() { 31.1, 3.9, 18.7, 9.7, 24.6, 14.3, 5.3, 10.8, 29.5, 7.5 }),
                new DoubleStack(new List<double>() { 27.6, 15.0, -38.2, 4.5, -20.9, 6.9, 12.9, 33.1, -11.4, 2.3 }),
                new DoubleStack(new List<double>() { 8.6, 23.0, 39.3, 17.1, 6.3, 30.8, 13.5, 25.2, 9.1, 3.0 }),
            };

            DoubleStack stackWithMaxTopElement = null;
            DoubleStack stackWithMinTopElement = null;
            List<DoubleStack> stacksWithNegativeElements = new List<DoubleStack>();

            foreach (DoubleStack stack in stacks) {
                if (stackWithMaxTopElement == null || stackWithMaxTopElement.Top < stack.Top) {
                    stackWithMaxTopElement = stack;
                }
                if (stackWithMinTopElement == null || stackWithMinTopElement.Top > stack.Top) {
                    stackWithMinTopElement = stack;
                }
                foreach (double value in stack) {
                    if (value < 0) {
                        stacksWithNegativeElements.Add(stack);
                        break;
                    }
                }
            }

            Console.WriteLine($"Stack with max top element: {stackWithMaxTopElement}");
            Console.WriteLine($"Stack with min top element: {stackWithMinTopElement}");
            Console.WriteLine($"Stacks with negative elements:\n\t{string.Join("\n\t", stacksWithNegativeElements)}");
        }

        public static void Task4() {
            var anonimStack = new { 
                Storage = new List<double>() { 12.5, 34.5, 18.2, -7.8 },
                Top = -7.8,
            };

            Console.WriteLine($"Top: {anonimStack.Top}");
            Console.WriteLine($"Storage: {{{string.Join(" ", anonimStack.Storage)}}}");
        }
    }
}
