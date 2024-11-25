class Solution:
    def romanToInt(self, s: str) -> int:
        length = len(s)
        roman_integers = { 
            'I': 1,
            'V': 5,
            'X': 10,
            'L': 50,
            'C': 100,
            'D': 500,
            'M': 1000
            }
        result = 0

        for i in range(0, length - 1):
            curr_roman = roman_integers[s[i]]
            next_roman = roman_integers[s[i + 1]]
            result =  result + curr_roman if curr_roman >= next_roman else result - curr_roman

        return result + roman_integers[s[length - 1]]
