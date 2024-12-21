public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int result = 0;
        for (int i = 1; i <= n; ++i)
        {
            result = i % m != 0 ? result + i : result - i;
        }
        return result;
    }
}
