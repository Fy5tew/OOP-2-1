using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab03 {
    internal class Program {
        static void Main(string[] args) {
            Queue<int> queue1 = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();

            Queue<int> queue3 = queue1 + 1;

            Console.WriteLine($"queue3: {queue3}");

            queue1 += 1;
            queue2 += 1;
            queue1 += 2;
            queue2 += 2;

            Console.WriteLine($"queue1: {queue1}");
            Console.WriteLine($"queue2: {queue2}");
            Console.WriteLine($"queue1 == queue2: {queue1 == queue2}");

            queue1--;

            Console.WriteLine($"queue1: {queue1}");
            Console.WriteLine($"queue2: {queue2}");
            Console.WriteLine($"queue1 == queue2: {queue1 == queue2}");

            if (queue3) {
                Console.WriteLine("queue3 is not empty");
            }
            else {
                Console.WriteLine("queue3 is empty");
            }

            Queue<int> queue4 = new Queue<int>();
            bool sucsess = queue3 > queue4;

            Console.WriteLine($"sucsess: {sucsess}");
            Console.WriteLine($"queue4: {queue4}");

            Console.WriteLine($"0 + queue2: {0 + queue2}");

            Console.WriteLine($"Count(queue2): {StaticOperation.Count(queue2)}");
            Console.WriteLine($"Sum(queue2): {StaticOperation.Sum(queue2)}");
            Console.WriteLine($"Min(queue2): {StaticOperation.Min(queue2)}");
            Console.WriteLine($"Max(queue2): {StaticOperation.Max(queue2)}");
            Console.WriteLine($"MinMaxDifference(queue2): {StaticOperation.MinMaxDifference(queue2)}");
            Console.WriteLine($"queue2.LastQueueElement(): {queue2.LastQueueElement()}");

            string str = "First. Second";
            Console.WriteLine($"str: \"{str}\"");
            Console.WriteLine($"str.FirstDotIndex(): {str.FirstDotIndex()}");
        }
    }
}
