using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algorithms;
namespace UnitTests
{
    public class BinarySearchTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 9, 10, 11 }, 16, null)]
        [InlineData(new int[] { 10, 19, 32, 34, 55, 65, 67, 71, 76, 80, 86, 93, 99, 129 }, 71, 71)]
        [InlineData(new int[] { 1, 5, 9, 100, 203, 250, 299, 310 }, 311, null)]
        public void Test(int[] ListValue, int target, int? expected)
        {
            var list = ListValue.ToList();
            var result = BinarySearch.FindTarget(list, target);
            Assert.Equal(expected, result);
        }
    }
}