public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        int Count0 = 0; int Count1 = 0;
        //Count Zeroes;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                Count0++;
            }
        }
        int output = Count0;
        /*
        *From left to right count of 0 decreases and count of 1 increases
        */
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                Count0--;
            }
            else if (s[i] == '1')
            {
                Count1++;
            }
            output = Math.Min(output, Count0 + Count1);
        }
        return output;
    }
}