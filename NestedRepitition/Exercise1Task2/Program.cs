using System;

namespace Exercise1Task2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter the number of times you want to print it: ");
            var countText = Console.ReadLine();

            try {
                var count = uint.Parse(countText);

                for(var i = 0; i < count; i += 1) {
                    for(var j = 0; j < count; j += 1) {
                        Console.Write(name);
                    }

                    Console.WriteLine();
                }
            } catch(Exception ex) when (ex is FormatException || ex is OverflowException) {
                Console.WriteLine("Invalid number");
            }

            Console.ReadKey(true);
        }
    }
}
