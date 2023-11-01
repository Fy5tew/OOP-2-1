using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07 {
    internal interface CollectionType<T> {
        void Append(T item);

        T Delete();

        void Show();
    }

    internal class CollectionError : Exception {
        public CollectionError(string message) : base(message) {
        
        }

        public CollectionError() : base() {

        }
    }
}
