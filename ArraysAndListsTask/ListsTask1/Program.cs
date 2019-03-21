using System;
using System.Collections.Generic;

namespace ListsTask1 {
    class Program {
        static void Main(string[] args) {
            try {
                var list = new List<int>();

                for(var i = 0; i < 5; i += 1) {
                    Console.Write("Enter number #" + (i + 1) + ": ");

                    var numberText = Console.ReadLine();

                    var number = int.Parse(numberText);

                    list.Add(number);
                }

                Console.Write("Enter a number: ");

                var testNumberText = Console.ReadLine();

                var testNumber = int.Parse(testNumberText);

                if(list.Contains(testNumber)) {
                    Console.WriteLine("The list already contains that number");
                } else {
                    Console.WriteLine("The list does not contain that number");
                }
            } catch(Exception ex) when (ex is FormatException || ex is OverflowException) {
                Console.WriteLine("Invalid number");
            }

            Console.ReadKey(true);
        }
    }
}
