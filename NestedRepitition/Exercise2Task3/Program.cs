using System;

namespace Exercise2Task3 {
    class Program {
        static void Main(string[] args) {
            for(var i = 0; i < 5; i += 1) {
                for(var j = 0; j < i + 1; j += 1) {
                    Console.Write('x');
                }

                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
