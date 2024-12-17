public class Solution
{
    public string DefangIPaddr(string address)
    {
        string result = "";
        for (int i = 0; i < address.Length; ++i)
        {
            result += address[i] == '.' ? "[.]" : address[i];
        }
        return result;
    }
}
