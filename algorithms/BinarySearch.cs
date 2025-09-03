namespace MyApp
{
    public static class BinarySearch
    {
        public static int? FindTarget(List<int> numbers, int target)
        {
            int low = 0;
            int high = numbers.Count - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = numbers[mid];
                if (guess == target)
                {
                    return numbers[mid];
                }
                else if (guess > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return null;
        }

    }

}