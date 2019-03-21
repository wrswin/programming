using System;

namespace Exercise2Task2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of lines you want to print: ");
            var countText = Console.ReadLine();

            try {
                var count = uint.Parse(countText);

                for(var i = count; i > 0; i -= 1) {
                    for(var j = 0; j < i; j += 1) {
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
