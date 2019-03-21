using System;

namespace AdvancedExerciseTask1 {
    class Program {
        static void Main(string[] args) {
            var lineCount = 6;
            var maxLineLength = (lineCount - 1) * 2 + 1;
            
            for(var i = lineCount - 1; i >= 0; i -= 1) {
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

            Console.ReadKey(false);
        }
    }
}
