public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int result = 0;
        Dictionary<char, bool> jeweleries = new Dictionary<char, bool>();
        foreach (char c in jewels)
        {
            jeweleries[c] = true;
        }
        foreach(char c in stones)
        {
            if (jeweleries.ContainsKey(c))
            {
                ++result;
            }
        }
        return result;
    }
}
