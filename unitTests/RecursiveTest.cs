using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algorithms;

namespace UnitTests
{
    public class RecursiveTest
    {
        [Theory]
        [InlineData(5, 120)]
        [InlineData(10, 3628800)]
        [InlineData(8, 40320)]
        [InlineData(6, 720)]
        [InlineData(12, 479001600)]
        [InlineData(4, 24)]
        [InlineData(3, 6)]
        [InlineData(1, 1)]
        [InlineData(7, 5040)]
        public void Test(int value, int expected)
        {
            var result = Recursive.Factorial(value);
            Assert.Equal(expected, result);
        }
    }
}
