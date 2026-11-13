public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        int[] frequency = new int[n + 1];

        foreach (int num in nums)
        {
            frequency[num]++;
        }

        int duplicate = -1;
        int missing = -1;

        for (int i = 1; i <= n; i++)
        {
            if (frequency[i] == 2)
            {
                duplicate = i;
            }
            else if (frequency[i] == 0)
            {
                missing = i;
            }
        }

        return new[] { duplicate, missing };
    }
}
