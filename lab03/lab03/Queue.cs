using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03 {
    internal partial class Queue<T> {
        private List<T> _storage;

        private Queue(List<T> storage) {
            this._storage = new List<T>(storage);
        }

        public Queue() : this(new List<T>()) { }

        public Queue(IEnumerable<T> collection) : this(new List<T>(collection)) { }

        public Queue(Queue<T> other) : this(other._storage) { }

        public T this[int index] {
            get => _storage[index];
        }

        public bool Empty {
            get => _storage.Count == 0;
        }

        public int Count {
            get => _storage.Count;
        }

        public T First {
            get => _storage[0];
        }

        public T Last {
            get => _storage[_storage.Count - 1];
        }

        public void Add(T item) {
            _storage.Add(item);
        }

        public void Clear() {
            _storage.Clear();
        }

        public bool Contains(T item) {
            return _storage.Contains(item);
        }

        public T Remove() {
            T value = _storage[0];
            _storage.RemoveAt(0);
            return value;
        }

        public bool Equals(Queue<T> other) {
            return _storage.SequenceEqual(other._storage);
        }

        public override bool Equals(object obj) {
            if (obj is Queue<T>) {
                return Equals((Queue<T>)obj);
            }
            return false;
        }

        public override string ToString() {
            return $"[{string.Join(",", _storage)}]";
        }

        public override int GetHashCode() {
            return -949379949 + EqualityComparer<List<T>>.Default.GetHashCode(_storage);
        }

        public static bool operator ==(Queue<T> left, Queue<T> right) {
            return left.Equals(right);
        }

        public static bool operator !=(Queue<T> left, Queue<T> right) {
            return !(left == right);
        }

        public static Queue<T> operator +(Queue<T> queue, T value) {
            Queue<T> newQueue = new Queue<T>(queue);
            newQueue.Add(value);
            return newQueue;
        }

        public static Queue<T> operator --(Queue<T> queue) {
            queue.Remove();
            return queue;
        }

        public static bool operator <(Queue<T> left, Queue<T> right) {
            left._storage = new List<T>(right._storage);
            return true;
        }

        public static bool operator >(Queue<T> left, Queue<T> right) {
            right._storage = new List<T>(left._storage);
            return true;
        }

        public static bool operator true(Queue<T> queue) {
            return !queue.Empty;
        }

        public static bool operator false(Queue<T> queue) {
            return queue.Empty;
        }

        public static implicit operator int(Queue<T> queue) {
            return queue.Count;
        }
    }
}
