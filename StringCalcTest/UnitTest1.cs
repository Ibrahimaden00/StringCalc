 using System;
using Xunit;
using StringCalculator;


namespace StringCalculator
{
    public class UnitTest1
    {



        [Fact]
        public void Test_Add_EmptyString_ShouldReturnZero()
        {
            var expected = 0;

            var result = Calculator.Add("");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Add_SingleNumber_ShouldReturnSingleNumber()
        {
            var expected = 3;

            var result = Calculator.Add("3");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Add_TwoNumbersSeperatedByComma_ShouldReturnSum()
        {
            var expected = 3;

            var result = Calculator.Add("1,2");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Add_TwoNumbersSeperatedBySlash_SshouldReturnSum()
        {
            var expected = 3;

            var result = Calculator.Add("1/2");
            Assert.Equal(expected, result);
            
        }


    }
}
