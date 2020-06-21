// https://leetcode.com/problems/add-strings/

public class Solution
{
  public string AddStrings(string num1, string num2)
  {
    if (num1.Length > num2.Length)
      num2 = num2.PadLeft(num1.Length, '0');
    else
      num1 = num1.PadLeft(num2.Length, '0');

    string result = "";
    int carry = 0;

    for (int i = num1.Length - 1; i >= 0; i--)
    {
      int sum = num1[i] + num2[i] - 96 + carry;
      result = (char)((sum % 10) + 48) + result;
      carry = sum / 10;
    }

    if (carry > 0)
      return (char)(carry + 48) + result;
    else if (result.Length == 0)
      return "0";

    return result;
  }
}