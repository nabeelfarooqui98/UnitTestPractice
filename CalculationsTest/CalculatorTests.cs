using Calculations;
using System;
using Xunit;

namespace CalculationsTest
{
    public class CalculatorTests
    {
        //System under test
        private readonly ICalculator _sut;
        public CalculatorTests()
        {
            _sut = new Calculator();
        }
        [Fact]
        public void ShouldAdd()
        {
            var res = _sut.Add(5.1m, 6.2m);
            Assert.Equal(11.3m, res);
        }
        [Theory]
        [InlineData(2,1,1)]
        [InlineData(-10,-15,5)]
        [InlineData(0,-1,1)]
        public void ShouldAddTheory(decimal expected, decimal value1, decimal value2)
        {
            var res = _sut.Add(value1, value2);
            Assert.Equal(expected, res);
        }
    }
}
