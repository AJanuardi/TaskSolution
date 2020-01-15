using System;

namespace FooBarBaz {
    public class Program16 {
        public static void Main (string[] args) {
            // Create a loop from 1 to 1000.
            // Each loop should print out a number.
            // But, there is some criteria:
            // 1) When the number multiplied by 5, the output will change like so "5. Foo".
            // 2) When the number multiplied by 20, the output will change like so "40. Bar".
            // 3) When the number multiplied by 100, the output will change like so "300. Baz".
        }

        public static string value (int input) {
            string val = "";
            for (int i = 0; i <= input; i++) {
                if (i % 5 == 0) {
                    if (i % 20 == 0) {
                        if (i % 100 == 0) {
                            val = "Baz";
                        } else
                            val = "Bar";
                    } else
                        val = "Foo";
                } else
                    Console.WriteLine ("{0}.", i);
            }
            return val;
        }
    }
}