namespace lab07 {
    internal class Program {
        static void Main(string[] args) {
            //Queue<int> intQueue = new Queue<int>() { 1, 2, 3 };
            //Queue<float> floatQueue = new Queue<float>() { 1.0f, 2.0f, 3.0f };
            //Queue<long> longQueue = new Queue<long>() { 1, 2, 3 };

            Queue<string> stringQueue = new Queue<string>() { "str1", "str2", "str3" };
            Console.Write("stringQueue: ");
            stringQueue.Show();

            Queue<Object> objectQueue = new Queue<Object>() { 1, 2, 3 };
            Console.Write("objectQueue: ");
            objectQueue.Show();

            Queue<dynamic> dynamicQueue = new Queue<dynamic>() { 1, "hello", 3.5f };
            Console.Write("dynamicQueue: ");
            dynamicQueue.Show();

            Console.WriteLine($"stringQueue.Remove(): {stringQueue.Remove()}");
            stringQueue.Append("hello");
            Console.Write("stringQueue: ");
            stringQueue.Show();

            while (stringQueue.Count > 0) {
                Console.WriteLine($"stringQueue.Remove(): {stringQueue.Remove()}");
            }

            try {
                Console.WriteLine($"stringQueue.Remove(): {stringQueue.Remove()}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Unknown exception | {ex.GetType().Name}: {ex.Message}");
            }
            finally {
                Console.Write($"stringQueue: ");
                stringQueue.Show();
            }

            Queue<Furniture> furnitureQueue = new Queue<Furniture>() { new Wardrobe(), new Sofa(), new Bed() };
            furnitureQueue.Show();


            Queue<string> serializationQueue = new Queue<string>() { "some", "very", "important", "queue" };
            string serializationFilename = """D:\Study\2c1s\OOP\lab07\lab07\SerializedQueue.json""";
            Deserialize<string>(serializationFilename);
            Serialize<string>(serializationFilename, serializationQueue);
            Deserialize<string>(serializationFilename);
        }

        public static void Serialize<T>(string filename, Queue<T> queue) where T : class {
            queue.SerializeToJsonFile(filename);
            Console.WriteLine($"Serialize | queue: {queue.ToString()}");
        }

        public static void Deserialize<T>(string filename) where T : class {
            Queue<T> queue = Queue<T>.DeserializeFromJsonFile<T>(filename);
            Console.WriteLine($"Deserialize | queue: {queue.ToString()}");
        }
    }
}