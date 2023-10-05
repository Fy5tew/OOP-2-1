using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal class Program {
        static void Main(string[] args) {

            (int Min, int Max, int Sum, char FirstLetter) Task5(int[] ints, string str) {
                int min = int.MaxValue;
                int max = int.MinValue;
                int sum = 0;
                char firstLetter;

                firstLetter = str[0];

                foreach (int element in ints) {
                    sum += element;
                    if (element < min) {
                        min = element;
                    }
                    if (element > max) {
                        max = element;
                    }
                }

                return (min, max, sum, firstLetter);
            }

            while (true) {
                Console.WriteLine("\n\nЗадания: ");
                Console.WriteLine("\t1a, 1b, 1c, 1df, 1e");
                Console.WriteLine("\t2a, 2b, 2c, 2d");
                Console.WriteLine("\t3a, 3b, 3c, 3d");
                Console.WriteLine("\t4abcd");
                Console.WriteLine("\t5");
                Console.WriteLine("\t6");
                Console.WriteLine("- для выхода");
                Console.Write("Выбор: ");
                string choice = Console.ReadLine();

                switch (choice) {
                    case "-":
                        Console.WriteLine("Выход...");
                        Environment.Exit(0);
                        break;
                    case "1a":
                        Task1a();
                        break;
                    case "1b":
                        Task1b();
                        break;
                    case "1c":
                        Task1c();
                        break;
                    case "1df":
                        Task1df();
                        break;
                    case "1e":
                        Task1e();
                        break;

                    case "2a":
                        Task2a();
                        break;
                    case "2b":
                        Task2b();
                        break;
                    case "2c":
                        Task2c();
                        break;
                    case "2d":
                        Task2d();
                        break;

                    case "3a":
                        Task3a();
                        break;
                    case "3b":
                        Task3b();
                        break;
                    case "3c":
                        Task3c();
                        break;
                    case "3d":
                        Task3d();
                        break;

                    case "4abcd":
                        Task4abcd();
                        break;

                    case "5":
                        WriteTitle("Task 5");
                        int[] ints = { 10, 5, 8, 1, 3, 7, };
                        string str = "Hello world!";
                        var returnValue = Task5(ints, str);
                        Console.WriteLine($"Min: {returnValue.Min}, Max: {returnValue.Max}, Sum: {returnValue.Sum}, FirstLetter: {returnValue.Sum},");
                        break;

                    case "6":
                        Task6();
                        break;

                    default:
                        Console.WriteLine("Неыерный номер задания");
                        break;
                }
            }
        }

        static void WriteTitle(string title) {
            Console.WriteLine($"\n\n{title,30}\n");
        }

        static void Task1a() {
            WriteTitle("Task 1a");

            bool boolValue = true;
            sbyte sbyteValue = -128;
            byte byteValue = 255;
            short shortValue = -3_276;
            ushort ushortValue = 65_535;
            int intValue = -2_147_483_648;
            uint uintValue = 4_294_967_295;
            long longValue = -9_223_372_036_854_775_808;
            ulong ulongValue = 18_446_744_073_709_551_615;
            float floatValue = 3.14159265359f;
            double doubleValue = 3.14159265359d;
            decimal decimalValue = 3.14159265359m;
            char charValue = '#';

            Console.Write("Input boolValue: ");
            boolValue = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Input sbyteValue: ");
            sbyteValue = Convert.ToSByte(Console.ReadLine());

            Console.Write("Input byteValue: ");
            byteValue = Convert.ToByte(Console.ReadLine());

            Console.Write("Input shortValue: ");
            shortValue = Convert.ToInt16(Console.ReadLine());

            Console.Write("Input ushortValue: ");
            ushortValue = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Input intValue: ");
            intValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input uintValue: ");
            uintValue = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Input longValue: ");
            longValue = Convert.ToInt64(Console.ReadLine());

            Console.Write("Input ulongValue: ");
            ulongValue = Convert.ToUInt64(Console.ReadLine());

            Console.Write("Input floatValue: ");
            floatValue = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input doubleValue: ");
            doubleValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input decimalValue: ");
            decimalValue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Input charValue: ");
            charValue = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Output boolValue: {boolValue} ({boolValue.GetType()})");
            Console.WriteLine($"Output sbyteValue: {sbyteValue} ({sbyteValue.GetType()})");
            Console.WriteLine($"Output byteValue: {byteValue} ({byteValue.GetType()})");
            Console.WriteLine($"Output shortValue: {shortValue} ({shortValue.GetType()})");
            Console.WriteLine($"Output ushortValue: {ushortValue} ({ushortValue.GetType()})");
            Console.WriteLine($"Output intValue: {intValue} ({intValue.GetType()})");
            Console.WriteLine($"Output uintValue: {uintValue} ({uintValue.GetType()})");
            Console.WriteLine($"Output longValue: {longValue} ({longValue.GetType()})");
            Console.WriteLine($"Output ulongValue: {ulongValue} ({ulongValue.GetType()})");
            Console.WriteLine($"Output floatValue: {floatValue} ({floatValue.GetType()})");
            Console.WriteLine($"Output doubleValue: {doubleValue} ({doubleValue.GetType()})");
            Console.WriteLine($"Output decimalValue: {decimalValue} ({decimalValue.GetType()})");
            Console.WriteLine($"Output charValue: {charValue} ({charValue.GetType()})");
        }

        static void Task1b() {
            WriteTitle("Task 1b");

            byte byteValue = 123;
            short shortValueFromByte = byteValue;

            float floatValueFromByte = byteValue;

            double doubleValueFromFloat = floatValueFromByte;

            char charValueFromByte = (char)byteValue;

            decimal decimalValueFromDouble = (decimal)doubleValueFromFloat;

            uint uintValueFromShort = (uint)shortValueFromByte;

            ulong ulongValueFromChar = charValueFromByte;

            int intValueFromUlong = (int)ulongValueFromChar;

            long longValueFromULong = (long)ulongValueFromChar;

            string stringValueFromByte = "" + byteValue;

            Console.WriteLine($"byteValue: {byteValue} ({byteValue.GetType()})");
            Console.WriteLine($"shortValueFromByte: {shortValueFromByte} ({shortValueFromByte.GetType()})");
            Console.WriteLine($"floatValueFromByte: {floatValueFromByte} ({floatValueFromByte.GetType()})");
            Console.WriteLine($"doubleValueFromFloat: {doubleValueFromFloat} ({doubleValueFromFloat.GetType()})");
            Console.WriteLine($"charValueFromByte: {charValueFromByte} ({charValueFromByte.GetType()})");
            Console.WriteLine($"decimalValueFromDouble: {decimalValueFromDouble} ({decimalValueFromDouble.GetType()})");
            Console.WriteLine($"uintValueFromShort: {uintValueFromShort} ({uintValueFromShort.GetType()})");
            Console.WriteLine($"ulongValueFromChar: {ulongValueFromChar} ({ulongValueFromChar.GetType()})");
            Console.WriteLine($"intValueFromUlong: {intValueFromUlong} ({intValueFromUlong.GetType()})");
            Console.WriteLine($"longValueFromULong: {longValueFromULong} ({longValueFromULong.GetType()})");
            Console.WriteLine($"stringValueFromByte: {stringValueFromByte} ({stringValueFromByte.GetType()})");
        }

        static void Task1c() {
            WriteTitle("Task 1c");

            int intValue = 156;
            double doubleValue = 144.78;

            object boxedIntValue = intValue;
            object boxedDoubleValue = doubleValue;

            Console.WriteLine($"Before Update: intValue: {intValue}; doubleValue: {doubleValue}");
            Console.WriteLine($"Before Update: boxedIntValue: {boxedIntValue}; boxedDoubleValue: {boxedDoubleValue}");

            intValue = 255;
            doubleValue = 785.781;

            Console.WriteLine($"After Update: intValue: {intValue}; doubleValue: {doubleValue}");
            Console.WriteLine($"After Update: boxedIntValue: {boxedIntValue}; boxedDoubleValue: {boxedDoubleValue}");

            int unboxedIntValue = (int)boxedIntValue;
            double unboxedDoubleValue = (double)boxedDoubleValue;

            Console.WriteLine($"unboxedIntValue: {unboxedIntValue}; unboxedDoubleValue: {unboxedDoubleValue}");

            try {
                short unboxedShortValueFromInt = (short)boxedIntValue;
                Console.WriteLine($"Successful unboxing of short value from boxed int: {unboxedShortValueFromInt}");
            }
            catch (InvalidCastException) {
                Console.WriteLine("InvalidCastException was catched while unboxing short value from boxed int");
            }
        }

        static void Task1df() {
            WriteTitle("Task 1d");

            var implicitlyTypedVariable = "Hello world!";

            dynamic dynamicTypedVariable = "Hello world!";

            object objectVariable = "Hello world!";

            Console.WriteLine($"Before changing type: implicitlyTypedVariable: {implicitlyTypedVariable} ({implicitlyTypedVariable.GetType()})");
            Console.WriteLine($"Before changing type: dynamicTypedVariable: {dynamicTypedVariable} ({dynamicTypedVariable?.GetType()})");
            Console.WriteLine($"Before changing type: objectVariable: {objectVariable} ({objectVariable?.GetType()})");

            dynamicTypedVariable = 125;
            objectVariable = 125;

            Console.WriteLine($"After changing type: implicitlyTypedVariable: {implicitlyTypedVariable} ({implicitlyTypedVariable.GetType()})");
            Console.WriteLine($"After changing type: dynamicTypedVariable: {dynamicTypedVariable} ({dynamicTypedVariable?.GetType()})");
            Console.WriteLine($"After changing type: objectVariable: {objectVariable} ({objectVariable?.GetType()})");
        }

        static void Task1e() {
            WriteTitle("Task 1e");

            int? nullableInt = null;
            Nullable<char> nullableChar = null;
            string defaultString = null;

            Console.WriteLine($"nullableInt: {nullableInt} ({nullableInt?.GetType()})");
            Console.WriteLine($"nullableChar: {nullableChar} ({nullableChar?.GetType()})");

            nullableInt = 123;
            nullableChar = 'c';

            Console.WriteLine($"nullableInt: {nullableInt} ({nullableInt?.GetType()})");
            Console.WriteLine($"nullableChar: {nullableChar} ({nullableChar?.GetType()})");
        }

        static void Task2a() {
            WriteTitle("Task 2a");

            string str1 = "hello";
            string str2 = "world";

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.Equals("hello"));
            Console.WriteLine(str2 == "world");
            Console.WriteLine(string.Equals(str1, str2));
            Console.WriteLine(string.Equals(str1, "hello"));
            Console.WriteLine(string.Equals(str2, "world"));
            Console.WriteLine(str1.CompareTo("hello"));
        }

        static void Task2b() {
            WriteTitle("Task 2b");

            string str1 = "This";
            string str2 = "is";
            string str3 = "string";

            string sentence1 = str1 + ' ' + str2 + ' ' + str3;
            string sentence1_2 = string.Concat(str1, ' ', str2, ' ', str3);

            string sentence2 = $"{str1} {str2} {str3}";
            string sentence2_2 = string.Format("{0} {1} {2}", str1, str2, str3);

            string sentence3 = sentence1;

            string substr = sentence1.Substring(5, 7);

            string[] words = sentence2.Split(' ');

            string addedSubstring = sentence3.Insert(8, "new ");

            string removedSubstring1 = sentence3.Remove(5, 2);
            string removedSubstring2 = sentence3.Replace("is", "");

            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");
            Console.WriteLine($"str3: {str3}");
            Console.WriteLine($"sentence1: {sentence1}");
            Console.WriteLine($"sentence1_2: {sentence1_2}");
            Console.WriteLine($"sentence3: {sentence2}");
            Console.WriteLine($"sentence2_2: {sentence2_2}");
            Console.WriteLine($"sentence3: {sentence3}");
            Console.WriteLine($"substr: {substr}");

            Console.Write("words: { ");
            foreach (string word in words) {
                Console.Write($"'{word}', ");
            }
            Console.WriteLine("}");

            Console.WriteLine($"addedSubstring: {addedSubstring}");
            Console.WriteLine($"removedSubstring1: {removedSubstring1}");
            Console.WriteLine($"removedSubstring2: {removedSubstring2}");
        }

        static void Task2c() {
            WriteTitle("Task 2c");

            string emptyStr = "";
            string whiteSpaceStr = " ";
            string nullStr = null;

            Console.WriteLine($"string.IsNullOrEmpty(emptyStr): {string.IsNullOrEmpty(emptyStr)}");
            Console.WriteLine($"string.IsNullOrEmpty(whiteSpaceStr): {string.IsNullOrEmpty(whiteSpaceStr)}");
            Console.WriteLine($"string.IsNullOrEmpty(nullStr): {string.IsNullOrEmpty(nullStr)}");

            Console.WriteLine($"string.IsNullOrWhiteSpace(emptyStr): {string.IsNullOrWhiteSpace(emptyStr)}");
            Console.WriteLine($"string.IsNullOrWhiteSpace(whiteSpaceStr): {string.IsNullOrWhiteSpace(whiteSpaceStr)}");
            Console.WriteLine($"string.IsNullOrWhiteSpace(nullStr): {string.IsNullOrWhiteSpace(nullStr)}");
        }

        static void Task2d() {
            WriteTitle("Task 2d");

            string initialString = "Its StringBuilder";

            StringBuilder stringBuilder = new StringBuilder(initialString);

            Console.WriteLine($"initialString length: {initialString.Length}");
            Console.WriteLine($"stringBuilder capacity: {stringBuilder.Capacity}");
            Console.WriteLine($"stringBuilder value: {stringBuilder}");

            stringBuilder.Remove(0, 3);
            Console.WriteLine($"stringBuilder capacity: {stringBuilder.Capacity}");
            Console.WriteLine($"stringBuilder value: {stringBuilder}");

            stringBuilder.Insert(0, "This");
            stringBuilder.Append(" is cool");
            Console.WriteLine($"stringBuilder capacity: {stringBuilder.Capacity}");
            Console.WriteLine($"stringBuilder value: {stringBuilder}");
        }

        static void Task3a() {
            WriteTitle("Task 3a");

            int[,] intMatrix = new int[5, 5];

            Random random = new Random();
            for (int i = 0; i < intMatrix.GetLength(0); i++) {
                for (int j = 0; j < intMatrix.GetLength(1); j++) {
                    intMatrix[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < intMatrix.GetLength(0); i++) {
                for (int j = 0; j < intMatrix.GetLength(1); j++) {
                    Console.Write($"{intMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Task3b() {
            WriteTitle("Task 3b");

            string[] stringArray = {
                "This is first string",
                "This is second string",
                "This is third string",
            };

            Console.WriteLine($"Array length: {stringArray.Length}");
            Console.Write("Array: { ");
            foreach (string str in stringArray) {
                Console.Write($"'{str}', ");
            }
            Console.WriteLine("}");

            Console.Write("Введите индекс для изменения: ");
            int indexToChange = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение для изменения: ");
            stringArray[indexToChange] = Console.ReadLine();

            Console.WriteLine($"Array length: {stringArray.Length}");
            Console.Write("Array: { ");
            foreach (string str in stringArray) {
                Console.Write($"'{str}', ");
            }
            Console.WriteLine("}");
        }

        static void Task3c() {
            WriteTitle("Task 3c");

            double[][] jaggedDoubleArray = new double[3][];
            jaggedDoubleArray[0] = new double[2];
            jaggedDoubleArray[1] = new double[3];
            jaggedDoubleArray[2] = new double[4];

            for (int i = 0; i < jaggedDoubleArray.Length; i++) {
                for (int j = 0; j < jaggedDoubleArray[i].Length; j++) {
                    Console.Write($"Ввод ({i}, {j}): ");
                    jaggedDoubleArray[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < jaggedDoubleArray.Length; i++) {
                for (int j = 0; j < jaggedDoubleArray[i].Length; j++) {
                    Console.Write($"{jaggedDoubleArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        static void Task3d() {
            WriteTitle("Task 3d");

            var implicitlyTypedString = "This is string";
            var implicitlyTypedArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        static void Task4abcd() {
            WriteTitle("Task 4a");

            (int, string, char, string, ulong) someTuple = (12, "string data", 'c', "some data", 12_567);
            (int A, double B) tuple1 = (11, 13.56);
            (int C, double D) tuple2 = (56, 13.56);
            (int E, double F) tuple3 = (11, 13.56);

            Console.WriteLine($"Full tuple: {someTuple}");
            Console.WriteLine($"Selectively tuple: Item1 ({someTuple.Item1}), Item3 ({someTuple.Item3}), Item4 ({someTuple.Item4})");

            Console.WriteLine($"tuple1 == tuple2: {tuple1 == tuple2}");
            Console.WriteLine($"tuple1 == tuple3: {tuple1 == tuple3}");

            var (A1, B1) = tuple1;
            (int A2, double B2) = tuple1;
            (var A3, double B3) = tuple1;

            int A4;
            double B4;
            (A4, B4) = tuple1;

            tuple2 = tuple1;
            Console.WriteLine($"tuple2: C ({tuple2.C}) D ({tuple2.D})");

            var (firstValue, _, _, _, _) = someTuple;
            Console.WriteLine($"firstValue: {firstValue}");
        }

        static void Task6() {
            WriteTitle("Task 6");

            int value = int.MaxValue;

            void Task6Checked() {
                checked {
                    Console.WriteLine(value + 5);
                }
            }

            void Task6Unchecked() {
                unchecked {
                    Console.WriteLine(value + 5);
                }
            }

            try {
                Console.WriteLine("Calling Task6Unchecked...");
                Task6Unchecked();

                Console.WriteLine("Calling Task6Checked...");
                Task6Checked();
            }
            catch (Exception exeption) {
                Console.WriteLine(exeption.ToString());
            }
        }
    }
}