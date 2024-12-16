public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] result = new int[nums.Length * 2];
        int i = 0, j = 0;
        while (i < nums.Length)
        {
            result[i] = nums[i];
            ++i;
        }
        while (i < result.Length)
        {
            result[i] = nums[j];
            ++i;
            ++j;
        }
        return result;
    }
}
