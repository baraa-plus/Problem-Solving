public class Solution
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        int[] result = new int[2];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int i = 0;
        foreach (int number in nums)
        {
            if (dict.ContainsKey(number))
            {
                result[i] = number;
                ++i;
            }
            else
            {
                dict[number] = 1;
            }
        }
        return result;
    }
}
