public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] sorted = nums.ToArray();
        Array.Sort(sorted);

        var smallerCount = new Dictionary<int, int>();

        for (int i = 0; i < sorted.Length; i++)
        {
            if (!smallerCount.ContainsKey(sorted[i]))
            {
                smallerCount[sorted[i]] = i;
            }
        }

        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = smallerCount[nums[i]];
        }

        return result;
    }
}
