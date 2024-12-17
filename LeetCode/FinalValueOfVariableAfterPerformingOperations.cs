public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int result = 0;
        for (int i = 0; i < operations.Length; ++i)
        {
            result = operations[i][1] == '+' ? ++result : --result;
        }
        return result;
    }
}
