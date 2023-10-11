using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03 {
    internal static class StaticOperation {
        public static int Min(Queue<int> queue) {
            int min = int.MaxValue;

            foreach (int value in queue) {
                if (value < min) {
                    min = value;
                }
            }

            return min;
        }

        public static int Max(Queue<int> queue) {
            int max = int.MinValue;

            foreach (int value in queue) {
                if (value > max) {
                    max = value;
                }
            }

            return max;
        }
        public static int MinMaxDifference(Queue<int> queue) {
            int min = Min(queue);
            int max = Max(queue);
            return max - min;
        }

        public static int Sum(Queue<int> queue) {
            int sum = 0;

            foreach (int value in queue) {
                sum += value;
            }

            return sum;
        }

        public static int Count(Queue<int> queue) {
            int count = 0;

            foreach (int value in queue) {
                count++;
            }

            return count;
        }

        public static int FirstDotIndex(this string str) {
            return str.IndexOf(".");
        }

        public static int LastQueueElement(this Queue<int> queue) {
            return queue[queue.Count - 1];
        }
    }
}
