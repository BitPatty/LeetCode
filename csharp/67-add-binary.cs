
// https://leetcode.com/problems/add-binary/

public class Solution
{
  public string AddBinary(string a, string b)
  {
    if (string.IsNullOrEmpty(a)) a = "0";
    if (string.IsNullOrEmpty(b)) b = "0";

    string[] splitA = (Enumerable.Range(1, a.Length / 32 + 1).Select(i => a.Substring(Math.Max(0, a.Length - i * 32), Math.Min(32, Math.Max(0, a.Length - (i - 1) * 32))))).ToArray();
    string[] splitB = (Enumerable.Range(1, b.Length / 32 + 1).Select(i => b.Substring(Math.Max(0, b.Length - i * 32), Math.Min(32, Math.Max(0, b.Length - (i - 1) * 32))))).ToArray();

    string res = "";
    PartialNum n = new PartialNum() { Value = 0, Carry = 0 };

    for (int i = 0; i < Math.Max(splitA.Length, splitB.Length); i++)
    {
      string strA, strB;
      strA = (i >= splitA.Length || splitA[i].Length == 0) ? "0" : splitA[i];
      strB = (i >= splitB.Length || splitB[i].Length == 0) ? "0" : splitB[i];

      n = Calc(strA, strB, n.Carry);

      res = Convert.ToString(n.Value, 2).PadLeft(32, '0') + res;
    }

    if (n.Carry == 1) res = "1" + res;
    res = res.TrimStart('0');
    return res.Length == 0 ? "0" : res;
  }

  public PartialNum Calc(string a, string b, uint carry)
  {
    uint s1 = Convert.ToUInt32(a, 2);
    uint s2 = Convert.ToUInt32(b, 2);

    ulong l = s1 + (ulong)s2 + carry;

    return new PartialNum() { Value = (uint)l, Carry = (uint)((l >> 32) & 0x1) };
  }

  public class PartialNum
  {
    public uint Value { get; set; }
    public uint Carry { get; set; }
  }
}