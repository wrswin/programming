using System;

namespace ArraysTask2 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };

            var sum = 0;
            for(var i = 0; i < numbers.Length; i += 1) {
                sum += numbers[i];
            }

            Console.WriteLine("The sum is: " + sum);

            Console.ReadKey(true);
        }
    }
}
