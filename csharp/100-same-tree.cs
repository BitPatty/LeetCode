// https://leetcode.com/problems/same-tree/

public class Solution
{
  public bool IsSameTree(TreeNode p, TreeNode q)
  {
    if (p?.val != q?.val) return false;

    return p == null
      || IsSameTree(p.left, q.left)
      && IsSameTree(p.right, q.right);
  }
}