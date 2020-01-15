using System;
using Xunit;
using YourName;
using StringLength;
using DaysToNextBirthday;
using Substitution;
using EvenOdd;
using Grade;
using LeapYear;
using MirrorString;
using Timezone;
using TempratureConverter;
using Calculator;
using ObjectClass;
using ToUpperCase;
using FruitFinder;
using SumArgument;
using Sorter;
using FindMinMaxAvg;
using CountWords;
using FooBarBaz;
using PalindromeDetector;
using System.Collections;


namespace Tester
{
    public class Tester
    {
        [Fact]
        public void Test_Your_Name()
        {
            Assert.Equal("Agung", Program.Printnama("Agung"));
        }
        [Fact]
        public void Test_Long()
        {
            Assert.Equal(5, Program1.CountString("Agung"));
        }
        [Fact]
        public void Test_Days()
        {
            Assert.Equal(5, Program2.gapYear("10/23/1996"));
        }

        [Fact]
         public void Test_Subs()
        {
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");
            Assert.Equal("Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.", Program3.CekValue("Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.", censoredWords));
        }

        [Fact]
        public void Test_OddEven()
        {
            Assert.True(Program4.isOdd(5));
            Assert.True(Program4.isEven(6));
        }
        [Fact]
        public void Test_Grade()
        {
            Assert.Equal('A', Program5.Grade(91));
            Assert.Equal('B', Program5.Grade(81));
            Assert.Equal('C', Program5.Grade(71));
            Assert.Equal('D', Program5.Grade(61));
            Assert.Equal('E', Program5.Grade(51));
        }
        
        [Fact]
        public void Test_Temperature()
        {
            Assert.Equal(30, Program6.CelciusToFahrenheit(91));
            Assert.Equal(30, Program6.CelciusToKelvin(81));
            Assert.Equal(30, Program6.KelvinToCelcius(71));
            Assert.Equal(30, Program6.KelvinToFahrenheit(61));
            Assert.Equal(30, Program6.FahrenheitToCelcius(51));
            Assert.Equal(30, Program6.FahrenheitToKelvin(51));
        }
        [Fact]
        public void Test_LeapYear()
        {
            Assert.True(Program7.IsLeapYear(2024));
        }
        [Fact]
        public void Test_Leap()
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);

            Assert.Equal("7", Program8.TimezoneDiff(jakarta, london));
        }
        [Fact]
        public void Test_Calc()
        {
            Assert.Equal(5, Program9.Sum(2, 3));            
            Assert.Equal(6, Program9.Multiply(2, 3));            
            Assert.Equal(1, Program9.Substract(3, 2));
            Assert.Equal(1, Program9.Divide(2, 2));
        }
        [Fact]
        public void Test_SumArg()
        {
             int[] num = {1,2,3,4,5};
             Assert.Equal(15, Program10.jumlah(num));
        }
        [Fact]
        public void Test_Upper()
        {
            Assert.Equal("BALL", Program11.Upper("ball"));
        }
        [Fact]
        public void Test_Count()
        {
            Assert.Equal(2, Program12.CountWords("BALL LOW"));
        }
        [Fact]
        public void Test_Palindrome()
        {
            Assert.True(Program13.IsPalindrome("rusak"));
        }
        [Fact]
        public void Test_Mirror()
        {
            Assert.Equal("-vv-", Program14.Mirror("-v"));
        }

        [Fact]
        public void Test_Finder()
        {
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };
            Assert.Equal(5, Program15.IndexFinder(fruits, "Kiwi"));
        }
        [Fact]
        public void Test_Foobar()
        {
            Assert.Equal("Baz", Program16.value(100));
            Assert.Equal("Foo", Program16.value(25));
            Assert.Equal("Bar", Program16.value(40));

        }
        [Fact]
        public void Test_FindMinMax()
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            Assert.Equal(330, Program17.FindMax(numbers));
            Assert.Equal(-65, Program17.FindMin(numbers));
            Assert.Equal(59, Program17.FindAverage(numbers));
        }
        [Fact]
        public void Test_Sort()
        {
            int[] number = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            int[] expected = {-65, -4, 2, 4, 12, 19, 40, 54, 56, 88, 92, 330};
            Assert.Equal(expected, Program18.Sort(number));
        }
        [Fact]
        public void Test_Object()
        {
            string expected = "Indomie Goreng (Rp 2800)";
            Item.name = "Indomie Goreng";
            Item.price = 3500;
            Item.onSale = true;

            Assert.Equal(expected, Item.testPrint());
        }

    }   
}
