using System;

namespace ArraysTask1 {
    class Program {
        static void Main(string[] args) {
            var names = new string[5];

            for(var i = 0; i < 5; i += 1) {
                Console.Write("Enter name #" + (i + 1) + ": ");

                names[i] = Console.ReadLine();
            }

            for(var i = 0; i < 5; i += 1) {
                Console.WriteLine("Hello " + names[i]);
            }

            Console.ReadKey(true);
        }
    }
}
