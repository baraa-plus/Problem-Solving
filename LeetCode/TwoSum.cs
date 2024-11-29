// Method-1 (Brute Force):
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; ++i)
        {
            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (nums[i] + nums[j] == target) return new int[] { i, j };
            }
        }
        return new int[] {};
    }
}

// Method-2 (Optimized):
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dictNums = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            int num = target - nums[i];
            if (dictNums.ContainsKey(num))
            {
                return new int[] { dictNums[num], i };
            }
            dictNums[nums[i]] = i;
        }
        return new int[] { };
    }
}
