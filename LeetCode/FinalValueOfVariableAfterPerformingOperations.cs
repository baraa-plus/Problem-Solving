public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int result = 0;
        for (int i = 0; i < operations.Length; ++i)
        {
            if (operations[i][1] == '+')
            {
                ++result;
            }
            else
            {
                --result;
            }
        }
        return result;
    }
}
