using System;
using Xunit;
using OddEven;
namespace OddEven_Test
{
    public class UnitTest1
    {
        [Theory] //i feel like i don't need this part cuz i could write it to the console and see. but, testing is the thing so....
        [InlineData(1, "Odd")]
        [InlineData(2, "Even")]
        [InlineData(25, "Odd")]
        [InlineData(40, "Even")]
        [InlineData(75, "Odd")]
        [InlineData(88, "Even")]

        public static void EvenCheckTest(int cknum,  string expected)
        {
            string actual = Numbers.EvenCheck(cknum);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(9, false)]
        [InlineData(11, true)]
        [InlineData(12, false)]
        [InlineData(13, true)]
        [InlineData(14, false)]
        [InlineData(25, false)]
        [InlineData(47, true)]
        [InlineData(100, false)]
        public static void IsPrimeCheckTest(int num, bool expected)
        {
            bool primecheck = Numbers.IsPrimeCheck(num);
            Assert.Equal(expected, primecheck);
        }

        [Theory]
        [InlineData(5, "Prime")]
        [InlineData(4, null)]
        [InlineData(7 ,"Prime")]
        [InlineData(11, "Prime")]
        [InlineData(13, "Prime")]
        [InlineData(47, "Prime")]
        [InlineData(8, null)]
        [InlineData(100, null)]
        [InlineData(89, "Prime")]

        public static void PrimePrintTest(int num, string expected)
        {
            string PrimePTest = Numbers.PrimePrint(num);
            Assert.Equal(expected, PrimePTest);
        }
    }
}
