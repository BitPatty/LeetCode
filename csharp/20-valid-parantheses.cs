// https://leetcode.com/problems/valid-parentheses/solution/

public class Solution
{
  public bool IsValid(string s)
  {
    Stack stack = new Stack();

    foreach (char c in s)
    {
      switch (c)
      {
        case '(': stack.Push(')'); break;
        case '[': stack.Push(']'); break;
        case '{': stack.Push('}'); break;
        case ')':
        case ']':
        case '}': if (stack.Count == 0 || !c.Equals((char)stack.Pop())) return false; break;
      }
    }

    return stack.Count == 0;
  }
}