using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    public static class Quicksortalgorithm
    {
        public static int[] Quicksort(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums;
            }
            var pivot = nums[0];
            var less = nums.Skip(1).Where(x => x < pivot).ToArray();
            var greater = nums.Skip(1).Where(x => x > pivot).ToArray();
            return Quicksort(less)
                .Concat(new int[] { pivot })
                .Concat(Quicksort(greater))
                .ToArray();
        }
    }
}

/*
1 - determine the base case, (array with 1 element or none)
2 - select pivot
3 - return 3 elements: [list with numbers less than pivot] + [pivot] + [list with number greater than pivot]
4 - recursion for all lists with 2 elements or more, until we reach the base case.
*/