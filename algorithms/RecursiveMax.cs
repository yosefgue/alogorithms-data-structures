using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    public static class RecursiveMax
    {
        public static int Max(List<int> nums)
        {
            if (nums.Count == 2)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }
            int maxof = Max(nums.Skip(1).ToList());
            return nums[0] > maxof ? nums[0] : maxof;
        }
    }
}
