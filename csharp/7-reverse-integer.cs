// https://leetcode.com/problems/reverse-integer/

public class Solution
{
  public int Reverse(int x)
  {
    long result = 0;

    do
    {
      result *= 10;
      result += x % 10;
      x /= 10;
    } while (x != 0);

    return Math.Abs(result) > Int32.MaxValue ? 0 : (int)result;
  }
}