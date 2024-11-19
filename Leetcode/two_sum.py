# Method-1 (brute force):
class Solution:
    def twoSum(self, nums, target: int):
        for i in range(len(nums) - 1):
            for j in range(i + 1, len(nums)):
                if nums[i] + nums[j] == target:
                    return [i, j]
# Method-2:
class Solution:
    def twoSum(self, nums, target: int):
        dict = {}
        for i in range(len(nums)):
            num = target - nums[i]
            if num in dict:
                return [dict[num], i]
            dict[nums[i]] = i
