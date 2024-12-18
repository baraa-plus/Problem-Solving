// Method - 1 (Brute Force):
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length - 1; ++i)
        {
            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (nums[i] == nums[j])
                {
                    ++result;
                }
            }
        }
        return result;
    }
}

// Method - 2:
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int result = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (dict.ContainsKey(i))
            {
                result += dict[i];
                ++dict[i];
            }
            else
            {
                dict[i] = 1;
            }
        }     
        return result;
    }
}
