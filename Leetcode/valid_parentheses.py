class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        for char in s:
            if char == '(' or char == '[' or char == '{':
                stack.append(char)
            elif (char == ')' or char == ']' or char == '}') and len(stack) == 0:
                return False
            else:
                top = stack.pop()
                if (top == '(' and char != ')') or (top == '[' and char != ']') or (top == '{' and char != '}'):
                    return False
        return len(stack) == 0
