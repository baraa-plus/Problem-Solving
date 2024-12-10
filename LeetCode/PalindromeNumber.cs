public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        string strX = x.ToString();
        int left = 0;
        int right = strX.Length - 1;

        while (left < right)
        {
            if (strX[left] != strX[right])
            {
                return false;
            }
            ++left;
            --right;
        }
        return true;
    }
}
