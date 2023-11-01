using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lab07 {
    internal partial class Queue<T> {
        public string SerializeToJsonString() {
            return JsonSerializer.Serialize(this._storage);
        }

        public void SerializeToJsonFile(string filename) {
            string serializedQueue = SerializeToJsonString();
            try {
                File.WriteAllText(filename, serializedQueue);
            }
            catch (Exception ex) {
                throw new CollectionError($"Can't write serialized Queue to file: {ex.GetType().Name}: {ex.Message}");
            }
        }

        public static Queue<K> DeserializeFromJsonString<K>(string jsonString) where K : class {
            List<K>? deserializedQueueStorage =  JsonSerializer.Deserialize<List<K>>(jsonString);
            if (deserializedQueueStorage is null) {
                throw new CollectionError("Can't deserialize Queue from JSON: Incorrect JSON scheme");
            }
            return new Queue<K>(deserializedQueueStorage);
        }

        public static Queue<K> DeserializeFromJsonFile<K> (string filename) where K : class {
            string serializedQueue;
            try {
                serializedQueue = File.ReadAllText(filename);
            }
            catch (Exception ex) {
                throw new CollectionError($"Can't read serialized Queue from file: {ex.GetType().Name}: {ex.Message}");
            }
            return DeserializeFromJsonString<K>(serializedQueue);
        }
    }
}
