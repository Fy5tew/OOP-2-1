using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08 {
    public class Programmer {
        public delegate void RenameEventHandler(string newName);

        public delegate void NewPropertyEventHandler(string key, string? value);

        public event RenameEventHandler? Rename;

        public event NewPropertyEventHandler? NewProperty;

        private string _name;

        private string? _pythonVersion;

        private string? _javaVersion;

        private string? _csharpVerion;

        public Programmer(string name) {
            _name = name;
        }

        public string Name {
            get => _name;
            set {
                _name = value;
                Rename?.Invoke(value);
            }
        }

        public string? PythonVersion {
            get => _pythonVersion;
            set {
                _pythonVersion = value;
                NewProperty?.Invoke("PythonVersion", value);
            }
        }

        public string? JavaVersion {
            get => _javaVersion;
            set {
                _javaVersion = value;
                NewProperty?.Invoke("JavaVersion", value);
            }
        }

        public string? CsharpVersion {
            get => _csharpVerion;
            set {
                _csharpVerion = value;
                NewProperty?.Invoke("CsharpVersion", value);
            }
        }

        public override string ToString() {
            return $"Programmer {_name} with " +
                $"Python-{_pythonVersion ?? "Null"} " +
                $"Java-{_javaVersion ?? "Null"} " +
                $"Csharp-{_csharpVerion ?? "Null"}";
        }
    }
}
