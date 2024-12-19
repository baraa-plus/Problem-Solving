public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int result = 0;
        foreach (int number in nums)
        {
            if (number % 3 != 0)
            {
                ++result;
            }
        }
        return result;
    }
}
