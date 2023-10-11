using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03 {
    internal partial class Queue<T> {
        Production QueueProduction = new Production(1, "BSTU");

        private class Production {
            int Id;
            string Organization;

            public Production(int id, string organization) {
                this.Id = id;
                this.Organization = organization;
            }
        }
    }
}
