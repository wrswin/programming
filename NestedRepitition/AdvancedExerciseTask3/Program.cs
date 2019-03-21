using System;

namespace AdvancedExerciseTask3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of lines you want to print: ");
            var lineCountText = Console.ReadLine();

            try {
                var lineCount = uint.Parse(lineCountText);
                var maxLineLength = (lineCount - 1) * 2 + 1;
            
                for(var i = 0; i < lineCount; i += 1) {
                    var lineLength = i * 2 + 1;
                    var spaceCount = (maxLineLength - lineLength) / 2;

                    for(var j = 0; j < spaceCount; j += 1) {
                        Console.Write(' ');
                    }

                    for(var j = 0; j < lineLength; j += 1) {
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
