public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var set = nums.ToHashSet();
        var result = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
