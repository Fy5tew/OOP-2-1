namespace lab08 {
    internal class Program {
        static void Main(string[] args) {
            Programmer programmer = new("Fy5tew");

            ProgrammingLanguage pythonLang = new("Python");
            ProgrammingLanguage javaLang = new("Java");
            ProgrammingLanguage csharpLang = new("Csharp");

            programmer.Rename += pythonLang.RenameEventHandler;
            programmer.Rename += javaLang.RenameEventHandler;
            programmer.Rename += csharpLang.RenameEventHandler;

            programmer.NewProperty += pythonLang.NewPropertyEventHandler;
            programmer.NewProperty += javaLang.NewPropertyEventHandler;
            programmer.NewProperty += csharpLang.NewPropertyEventHandler;

            PrintInfo("Before updating", programmer, pythonLang, javaLang, csharpLang);

            programmer.Name = "Nikita";

            PrintInfo("After updating name", programmer, pythonLang, javaLang, csharpLang);

            programmer.PythonVersion = "3.10";
            programmer.PythonVersion = "3.11";

            PrintInfo("After multiple updating Python version", programmer, pythonLang, javaLang, csharpLang);

            programmer.CsharpVersion = "7.3";

            PrintInfo("After updating Csharp version", programmer, pythonLang, javaLang, csharpLang);

            programmer.JavaVersion = "8";

            PrintInfo("After updating Java version", programmer, pythonLang, javaLang, csharpLang);


            Action<string> PrintString = (string str) => Console.WriteLine($"String: '{str}'");
            Func<string, string> RemovePunctuation = (string str) => str.Replace(".", "").Replace(",", "");
            Func<string, string> RemoveQuotes = (string str) => str.Replace("'", "").Replace("\"", "");
            Func<string, string> ToTitle = (string str) => str.ToUpper()[0] + str.ToLower().Remove(0, 1);
            Func<string, Predicate<string>> CompareToResult = (string result) => (string str) => str == result;

            string oldString = ".sOme VeRy 'dirty' \"StRiNg\"";
            string result = "Some very dirty string";
            Func<string, string>[] funcs = { RemoveQuotes, RemovePunctuation, ToTitle }; 
            var (newString, match) = ProcessString(oldString, funcs, CompareToResult(result), PrintString);

            Console.WriteLine($"oldString: '{oldString}'");
            Console.WriteLine($"result: '{result}'");
            Console.WriteLine($"newString: '{newString}'");
            Console.WriteLine($"match: {match}");
        }

        static void PrintInfo(
            string title,
            Programmer programmer, 
            ProgrammingLanguage python, 
            ProgrammingLanguage java, 
            ProgrammingLanguage csharp
        ) {
            Console.WriteLine($"\t{title}");
            Console.WriteLine(programmer);
            Console.WriteLine(python);
            Console.WriteLine(java);
            Console.WriteLine(csharp);
            Console.WriteLine();
        }

        static (string, bool) ProcessString(
            string str, 
            Func<string, string>[] functions,
            Predicate<string> predicate,
            Action<string> action
        ) {
            foreach ( Func<string, string> func in functions ) {
                str = func( str );
            }
            action( str );
            return (str, predicate(str));
        }
    }
}