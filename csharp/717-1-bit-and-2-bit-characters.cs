
// https://leetcode.com/problems/1-bit-and-2-bit-characters/

public class Solution
{
  public bool IsOneBitCharacter(int[] bits)
  {
    if (bits.Length < 2) return true;
    else if (bits[^1] == 1) return false;
    else if (bits.Length < 3) return bits[0] == 0;
    else if (bits.Length == 3) return bits[0] == 1 || (bits[0] + bits[1] == 0);
    else if (bits[^2] == 0) return true;
    else if (bits[^3] == 0) return false;
    else if (bits.Length == 4) return bits[0] == 0;
    else
    {
      bool swp = true;

      for (int i = bits.Length - 6; i >= 1; i -= 3)
      {
        if (bits[i + 1] == 0 && bits[i + 2] == 1) return !swp;
        if (bits[i] + bits[i + 1] + bits[i + 2] != 3) return swp;
        if (bits[i - 1] == 0) return (bits[i] == 0) == swp;

        swp = !swp;
      }

      return bits[0] == bits[1] && bits[0] == 1 || bits[1] == 0 ? swp : !swp;
    }
  }
}
