using System;

namespace Exercise1Task1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            for(var i = 0; i < 10; i += 1) {
                for(var j = 0; j < 10; j += 1) {
                    Console.Write(name);
                }

                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
