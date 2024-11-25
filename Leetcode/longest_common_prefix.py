class Solution:
    def longestCommonPrefix(self, strs) -> str:
        length = len(strs)
        if length == 1:
            return strs[0]
        if length == 0:
            return ""
        
        longest_prefix = strs[0]

        i = 1
        while i < len(strs):
            j = 0
            temp = ""
            while j < len(strs[i]) and j < len(longest_prefix):
                if strs[i][j] == longest_prefix[j]:
                    temp += longest_prefix[j]
                elif temp == "":
                    return ""
                else:
                    break
                j += 1
            longest_prefix = temp if len(temp) < len(longest_prefix) else longest_prefix
            i += 1
        return longest_prefix
