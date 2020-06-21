// https://leetcode.com/problems/two-sum/

public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
      if (dict.ContainsKey(target - nums[i]))
        return new int[] { i, dict[target - nums[i]] };
      else if (!dict.ContainsKey(nums[i]))
        dict.Add(nums[i], i);

    return null;
  }
}