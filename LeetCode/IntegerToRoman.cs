public class Solution
{
    public string IntToRoman(int num)
    {
        string result = "";
        string[] romanNumerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] integers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        for (int i = 0; i < romanNumerals.Length; ++i)
        {
            while (num >= integers[i])
            {
                result += romanNumerals[i];
                num -= integers[i];
            }
        }
        return result;
    }
}
