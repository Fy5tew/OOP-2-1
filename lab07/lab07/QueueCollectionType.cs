using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07 {
    internal partial class Queue<T> : CollectionType<T> {
        public void Append(T item) {
            Add(item);
        }

        public T Delete() {
            try {
                return Remove();
            }
            catch (CollectionError err) {
                throw new CollectionError($"Error while excecuting 'Delete' method: {err.Message}");
            }
        }

        public void Show() {
            Console.WriteLine(this.ToString());
        }
    }
}
