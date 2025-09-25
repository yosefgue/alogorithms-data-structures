int Sum(List<int> nums)
{
    if (nums.Count == 1)
    {
        return nums[0];
    }
    else
    {
        int anumber = nums[0];
        nums.RemoveAt(0);
        return anumber + Sum(nums);
    }
}

Console.WriteLine(Sum(new List<int> { 1, 2, 3 }));