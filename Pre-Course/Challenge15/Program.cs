using System;

namespace MirrorString
{
    public class Program14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Mirror("--vv")); // Output: --vvvv--
        }

        public static string Mirror(string text)
        {
            int ln = text.Length;
            for(int i=0; i<ln; i++)
                text += text[ln-i-1];

            return text;
        }
    }
}
