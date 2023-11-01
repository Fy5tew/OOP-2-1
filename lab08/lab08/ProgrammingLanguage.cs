using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08 {
    internal class ProgrammingLanguage {
        private string _title;

        private string? _version;

        private string? _programmerName;

        public ProgrammingLanguage(string title) {
            _title = title;
        }

        public string Title {
            get => _title;
        }

        public string? Version {
            get => _version;
        }
        
        public string? ProgrammerName {
            get => _programmerName;
        }

        public void RenameEventHandler(string newName) {
            _programmerName = newName;
        }

        public void NewPropertyEventHandler(string key, string? value) {
            if (key == $"{_title}Version") {
                _version = value;
            }
        }

        public override string ToString() {
            return $"Programming language {_title}-{_version ?? "Null"} developed by {_programmerName ?? "None"}";
        }
    }
}
