using System;

namespace Sorter
{
    public class Program18
    {
        static void Main(string[] args)
        {
            // Create sorted numbers of points
            int[] points = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
            Console.WriteLine(Sort(points));
        }
        public static int[] Sort(int[] num)
        {
            Array.Sort(num);
            foreach (int i in num)
            Console.Write("{0}  ", i);
            return num;
        }
    }
}