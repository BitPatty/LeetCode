// https://leetcode.com/problems/add-two-numbers/

public class Solution
{
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
  {
    Sum(l1, l2);
    return l1;
  }

  public static void Sum(ListNode l1, ListNode l2, int carry = 0)
  {
    l1.val += carry + (l2?.val ?? 0);
    carry = l1.val / 10;
    l1.val %= 10;

    if (l1.next == null && l2?.next != null)
    {
      l1.next = l2.next;
      l2.next = null;
    }

    if (l1.next != null)
      Sum(l1.next, l2?.next, carry);
    else if (carry > 0)
      l1.next = new ListNode(carry);
  }
}