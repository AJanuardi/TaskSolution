using System;
using Xunit;
using System.Collections.Generic;
using ChallengeApp;

namespace Program
{
    public class TestingChallengeApp
    {
        [Fact]
        public void Test_BasicStat()
        {
            int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
            Assert.Equal(100, BasicStatistic.FindMax(numbers));
            Assert.Equal(-19, BasicStatistic.FindMin(numbers));
            Assert.Equal(17, BasicStatistic.CalculateAverage(numbers));
        }
        [Fact]
        public void Test_FlatArray()
        {
           int[] theFirstArray = { 2, 52, 56, 12, 3 };
            int[] theSecondArray = { 1, 0, 65, 42 };
            int[] theThirdArray = { 3, 4, 6 };
            int[] expected = {1, 0, 2, 3, 4, 6, 12, 42, 52, 56, 65};
            Assert.Equal(expected, FlatArray.Combine());
        }
        [Fact]
        public void Test_HowManyDup()
        {
            int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
            string expected = "1 -> 2x \n"
                             +"2 -> 1x \n"
                             +"3 -> 3x \n"
                             +"4 -> 2x \n"
                             +"5 -> 3x \n";
            Assert.Equal(expected, HowManyDuplicates.Dup(dups));
        }
        [Fact]
        public void Test_Multiply()
        {
            int[] array = new int[4];
            int[] first = {1, 3, -5, 4};
            int[] second = {1, 4, -5, -2};
            int[] expected = {1, 12, 25, -8};
            Assert.Equal(expected, MultiplicationOfTwoArray.Run());
        }
        [Fact]
        public void Test_Separator()
        {
            string expected = "m-i-n-u-m-s-u-s-u-s-a-p-i";
            Assert.Equal(expected, Separator.Run());
        }
        [Fact]
        public void Test_TriangleNumber()
        {
            string expected = "1\n"
                            +"12\n";
            Assert.Equal(expected, TriangleOfNumbers.Run(2));
        }
        [Fact]
        public void Test_TriangleStars()
        {
            string expected = "*\n"
                            +"**\n";
            Assert.Equal(expected, TriangleOfStars.Run(2));
        }
        [Fact]
        public void Test_Vowel()
        {
            string expected = "rAsAnyA OtAkkU sEmAkIn kErAm";
            Assert.Equal(expected, VowelToUppercase.Run());
        }
        [Fact]
        public void Test_Generate()
        {
            string expected = "January         2020"
                             +"--------------------"
                             +"Su Mo Tu We Th Fr Sa"
                             +"          1  2  3  4 \n"
                             +" 5  6  7  8  9 10 11 \n"
                             +"12 13 14 15 16 17 18 \n"
                             +"19 20 21 22 23 24 25 \n"
                             +"26 27 28 29 30 31    ";
            Assert.Equal(expected, GenerateCalendar.Run());
        }

    }
}
