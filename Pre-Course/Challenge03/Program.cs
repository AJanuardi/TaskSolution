using System;

namespace StringLength
{
    public class Program1
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("have {0} characters", CountString("Agung"));
        }
        public static int CountString(string args)
        {
            int number = args.Length;
            return number;
        }


    }
}
