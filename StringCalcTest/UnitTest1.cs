 using System;
using Xunit;
using StringCalculator;


namespace StringCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void Add_EmptyString_ShouldReturnZero()
        {
            var expected = 0;

            var result = Calculator.Add("");

            Assert.Equal(expected, result);
        }
    }
}
