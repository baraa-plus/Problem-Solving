public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int result = 0;

        for (int i = 0; i < s.Length - 1; ++i)
        {
            int next = i + 1;
            if (romanValues[s[i]] < romanValues[s[next]])
            {
                result -= romanValues[s[i]];
            }
            else
            {
                result += romanValues[s[i]];
            }
        }
        result += romanValues[s[s.Length - 1]];
        return result;
    }
}
