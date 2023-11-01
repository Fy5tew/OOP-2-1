using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07 {
    internal partial class Queue<T> : IEnumerable {
        public IEnumerator GetEnumerator() {
            return new QueueEnumerator(this);
        }

        private class QueueEnumerator : IEnumerator {
            private Queue<T> _queue;
            private int _index = -1;
            private IEnumerator GetEnumerator() {
                return (IEnumerator)this;
            }

            public QueueEnumerator(Queue<T> queue) {
                _queue = queue;
            }

            public bool MoveNext() {
                _index++;
                return (_index < _queue.Count);
            }

            public void Reset() {
                _index = -1;
            }

            public Object Current {
                get => _queue[_index];
            }
        }
    }
}
