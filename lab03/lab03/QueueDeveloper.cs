using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03 {
    internal partial class Queue<T> {
        Developer QueueDeveloper = new Developer(1, "Turchinovich Nikita Alexandrovich", "BSTU");

        private class Developer {
            int Id;
            string Name;
            string Department;

            public Developer(int id, string name, string department) {
                this.Id = id;
                this.Name = name;
                this.Department = department;
            }
        }
    }
}
