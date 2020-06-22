// https://leetcode.com/problems/binary-search/

public class Solution
{
  public int Search(int[] nums, int target)
  {
    if (nums.Length == 0) return -1;
    if (target < nums[0] || target > nums[^1]) return -1;
    if (target == nums[0]) return 0;
    if (target == nums[^1]) return nums.Length - 1;

    int idx = nums.Length / 2;

    for (int step = idx / 2; step > 0; step /= 2)
    {
      if (nums[idx] == target)
        return idx;
      else if (nums[idx] > target)
        idx -= step + 1;
      else
        idx += step + 1;
    }

    for (int i = idx - 1; i < idx + 2; i++)
      if (target == nums[i]) return i;

    return -1;
  }
}