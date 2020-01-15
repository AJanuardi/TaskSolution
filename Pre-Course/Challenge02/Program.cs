using System;

namespace DaysToNextBirthday
{
    public class Program2
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Next Bhirtday");
            string tgl = Console.ReadLine();
            int gap = gapYear(tgl);
            Console.WriteLine("{0} next day, gap");
        }
        public static int gapYear(string date)
        {
            var today = DateTime.Now;
            DateTime Bhirtday = DateTime.Parse(date);
            TimeSpan gap = Bhirtday - today;
            return (Convert.ToInt32(gap.Days));
        }
}
}
