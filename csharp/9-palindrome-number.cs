// https://leetcode.com/problems/palindrome-number/

public class Solution
{
  public bool IsPalindrome(int x)
  {
    if (x < 0) return false;
    if (x < 10) return true;

    string numStr = x.ToString();

    for (int i = 0; i < numStr.Length / 2; i++)
      if (numStr[i] != numStr[^(i + 1)]) return false;

    return true;
  }
}