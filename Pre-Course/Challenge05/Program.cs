using System;

namespace EvenOdd
{
    public class Program4
    {
        
        public static bool isOdd(int args)
        {
            if(args%2 == 1)
                return true;

            else return false;
        }


        public static bool isEven(int args)
        {
            if(args%2 == 0)
                return true;

            else return false;
        }
        

        public static void Main(string[] args)
        {
            // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true
            int inp = int.Parse(Console.ReadLine());
            Console.WriteLine("Is odd? " +  isOdd(inp));
            Console.WriteLine("Is even? " + isEven(inp));
        }
    }
}
