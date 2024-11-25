class Solution:
    def reverse(self, x: int) -> int:
        result = 0
        sign = -1 if x < 0 else 1
        x = abs(x)
        while x != 0:
            result = (result * 10) + (x % 10)
            x //= 10
        result *= sign
        return result if (result < 2147483651 and result > -2147483651) else 0
