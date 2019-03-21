using System;

namespace Exercise2Task1 {
    class Program {
        static void Main(string[] args) {
            for(var i = 5; i > 0; i -= 1) {
                for(var j = 0; j < i; j += 1) {
                    Console.Write('x');
                }

                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
