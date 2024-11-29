public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        int len = strs.Length;
        if (len == 0)
        {
            return "";
        }
        if (len == 1)
        {
            return strs[0];
        }
        string longestCommonPrefix = strs[0];
        for (int i = 1; i < len; ++i)
        {
            string temp = "";
            int j = 0;
            while (j < strs[i].Length && j < longestCommonPrefix.Length)
            {
                if (strs[i][j] == longestCommonPrefix[j])
                {
                    temp += longestCommonPrefix[j];
                }
                else if (temp == "")
                {
                    return "";
                }
                else
                {
                    break;
                }
                ++j;
            }
            if (temp.Length < longestCommonPrefix.Length)
            {
                longestCommonPrefix = temp;
            }
        }
        return longestCommonPrefix;
    }
}
