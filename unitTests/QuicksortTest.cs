using algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTests
{
    public class QuicksortTest
    {
        [Theory]
        [InlineData(new int[] { 12, 5, 97, 33, 41 }, new int[] { 5, 12, 33, 41, 97 })]
        [InlineData(new int[] { 87, 23, 45, 9, 10, 54, 32 }, new int[] { 9, 10, 23, 32, 45, 54, 87 })]
        [InlineData(new int[] { 4, 2, 78, 99, 13, 65, 31, 7 }, new int[] { 2, 4, 7, 13, 31, 65, 78, 99 })]
        [InlineData(new int[] { 91, 14, 62, 38, 49, 26 }, new int[] { 14, 26, 38, 49, 62, 91 })]
        [InlineData(new int[] { 5, 81, 17, 63, 27, 44, 2, 0, 19 }, new int[] { 0, 2, 5, 17, 19, 27, 44, 63, 81 })]
        [InlineData(new int[] { 72, 8, 55, 23, 3, 41, 66 }, new int[] { 3, 8, 23, 41, 55, 66, 72 })]
        [InlineData(new int[] { 15, 39, 77, 88, 12, 56, 7, 6, 4 }, new int[] { 4, 6, 7, 12, 15, 39, 56, 77, 88 })]
        [InlineData(new int[] { 9, 20, 51, 33, 45, 11, 70, 18 }, new int[] { 9, 11, 18, 20, 33, 45, 51, 70 })]
        [InlineData(new int[] { 2, 5, 14, 67, 89, 34, 12, 10, 4, 26 }, new int[] { 2, 4, 5, 10, 12, 14, 26, 34, 67, 89 })]
        [InlineData(new int[] { 3, 19, 42, 31, 9, 55, 66 }, new int[] { 3, 9, 19, 31, 42, 55, 66 })]
        [InlineData(new int[] { 123, 5, 67, 89, 34, 12, 78, 56, 90, 11, 22, 44, 33, 55, 66, 99, 1, 3, 7, 8, 15, 19, 21, 24, 28, 32, 35, 38, 40, 42 },
            new int[] { 1, 3, 5, 7, 8, 11, 12, 15, 19, 21, 22, 24, 28, 32, 33, 34, 35, 38, 40, 42, 44, 55, 56, 66, 67, 78, 89, 90, 99, 123 })]
        [InlineData(new int[] { 90, 23, 5, 12, 44, 33, 77, 56, 67, 2, 1, 3, 8, 11, 17, 20, 29, 30, 31, 39, 41, 43, 45, 46, 47, 48, 49, 50, 51, 52 },
            new int[] { 1, 2, 3, 5, 8, 11, 12, 17, 20, 23, 29, 30, 31, 33, 39, 41, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 56, 67, 77, 90 })]

        public void Test(int[] arrayValue, int[] expected)
        {
            int[] result = Quicksortalgorithm.Quicksort(arrayValue);
            Assert.Equal(expected, result);
        }
    }
}
