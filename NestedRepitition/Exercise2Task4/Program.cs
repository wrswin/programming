using System;

namespace Exercise2Task4 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of lines you want to print: ");
            var countText = Console.ReadLine();

            try {
                var count = uint.Parse(countText);

                for(var i = 0; i < count; i += 1) {
                    for(var j = 0; j < i + 1; j += 1) {
                        Console.Write('x');
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
